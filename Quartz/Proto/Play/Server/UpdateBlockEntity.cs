using EncodingLib;
using EncodingLib.Nbt;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class UpdateBlockEntity : IOutPacket
    {
        public const int IdConst = 0x09;

        public BlockPos Location { get; set; }
        public byte Action { get; set; }
        public NbtBlob NbtData { get; set; }
        
        public int Id => IdConst;
        
        public void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteByte(Action);
            writer.WriteNbtBlob(NbtData);
        }
    }
}
