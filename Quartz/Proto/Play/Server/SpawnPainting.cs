using System;
using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class SpawnPainting : IOutPacket
    {
        public const int IdConst = 0x04;
        
        public int EntityId { get; set; }
        public Guid Uuid { get; set; }
        public Painting Painting { get; set; }
        public BlockPos Location { get; set; }
        public DirectionEnum Direction { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint(EntityId);
            writer.WriteUuidProto(Uuid);
            writer.WriteStringProto(Painting.Name);
            writer.WriteBlockPosProto(Location);
            writer.WriteByte((byte)Direction);
        }

        public enum DirectionEnum
        {
            South,
            West,
            North,
            East
        }
    }
}
