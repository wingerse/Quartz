using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class BlockAction : OutPacket
    {
        public const int IdConst = 0x0a;

        public BlockPos Location { get; set; }
        public byte Action { get; set; }
        public byte Param { get; set; }
        public Block.Block Block { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteBlockPosProto(Location);
            writer.WriteByte(Action);
            writer.WriteByte(Param);
            writer.WriteVarint(Block.Id);
        }
    }
}
