using EncodingLib;
using EncodingLib.Nbt;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class UpdateBlockEntity : OutPacket
    {
        public BlockPos Location { get; set; }
        public byte Action { get; set; }
        public NbtBlob NbtData { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteByte(Action);
            writer.WriteNbtBlob(NbtData);
        }
    }
}
