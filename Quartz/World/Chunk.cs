using System.IO;
using EncodingLib;
using Quartz.Block;
using Quartz.Proto.Play.Server;

namespace Quartz.World
{
    public sealed class Chunk
    {
        public const ushort FullBitMask = (1 << 16) - 1;
        
        public ChunkPos Coordinates { get; }
        
        private readonly ChunkSection[] _sections = new ChunkSection[16];
        private readonly byte[] _biomes = new byte[256];
        // TODO: block entities.

        public Chunk(ChunkPos coordinates)
        {
            Coordinates = coordinates;
        }

        public BlockStateId this[BlockPos pos]
        {
            get
            {
                var sec = _sections[pos.Y / 16];
                if (sec == null)
                    return new BlockStateId(Air.IdConst, 0);
                return sec[new ChunkSection.BlockPos(pos)];
            }
            set
            {
                if (_sections[pos.Y / 16] == null)
                {
                    if (value.Id == Air.IdConst) return;
                    _sections[pos.Y / 16] = new ChunkSection(true); // TODO: introduce worlds with no skylight.
                }
                _sections[pos.Y / 16][new ChunkSection.BlockPos(pos)] = value;
                if (_sections[pos.Y / 16].IsEmpty)
                {
                    _sections[pos.Y / 16] = null;
                }
            }
        }

        /// <summary>
        /// Creates a ChunkData packet based on this chunk (a snapshot). 
        /// The mask parameter is used to determine which sections to include.
        /// Null sections will still not be included even if it's present in mask.
        /// </summary>
        public ChunkData CreatePacket(ushort mask)
        {
            var packet = new ChunkData();

            var mem = new MemoryStream();
            var writer = new PrimitiveWriter(mem);
            for (var i = 0; i < _sections.Length; i++)
            {
                var sec = _sections[i];
                if (sec != null && (mask & (1 << i)) != 0)
                {
                    packet.BitMask |= (ushort)(1 << i);
                    writer.WriteChunkSectionProto(sec);
                }
            }

            packet.Coordinates = Coordinates;
            packet.IsNew = mask == FullBitMask;
            if (packet.IsNew)
            {
                writer.Write(_biomes, 0, _biomes.Length);
            }
            
            packet.Data = mem.ToArray();
            
            return packet;
        }
        
        public struct BlockPos
        {
            public byte X { get; }
            public byte Y { get; }
            public byte Z { get; }

            public BlockPos(byte x, byte y, byte z)
            {
                X = (byte)(x & 0xf);
                Y = y;
                Z = (byte)(z & 0xf);
            }
        }
    }
}
