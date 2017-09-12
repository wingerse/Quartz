using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class ChunkData : OutPacket
    {
        public const int IdConst = 0x20;

        public ChunkPos Coordinates { get; set; }
        public bool IsNew { get; set; }
        public ushort BitMask { get; set; }
        public byte[] Data { get; set; }
        // TODO: Block entities
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(Coordinates.X);
            writer.WriteInt(Coordinates.Z);
            writer.WriteBool(IsNew);
            writer.WriteVarint(BitMask);
            writer.WriteVarint(Data.Length);
            writer.Write(Data, 0, Data.Length);
            // TODO: Block entities. This is the length of block entity nbt array.
            writer.WriteVarint(0);
        }
    }
}
