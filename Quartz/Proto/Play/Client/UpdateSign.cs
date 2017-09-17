using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Client
{
    public sealed class UpdateSign : InPacket
    {
        public BlockPos Location { get; private set; }
        public string Line1 { get; private set; }
        public string Line2 { get; private set; }
        public string Line3 { get; private set; }
        public string Line4 { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Location = reader.ReadBlockPosProto();
            Line1 = reader.ReadStringProto(384);
            Line2 = reader.ReadStringProto(384);
            Line3 = reader.ReadStringProto(384);
            Line4 = reader.ReadStringProto(384);
        }
    }
}
