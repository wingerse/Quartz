using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Client
{
    public sealed class TabComplete : InPacket
    {
        public string Text { get; private set; }
        public bool AssumeCommand { get; private set; }
        /// <summary>
        /// Can be null.
        /// </summary>
        public BlockPos? LookedAtBlock { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Text = reader.ReadStringProto(ProtoConsts.MaxStringChars);
            AssumeCommand = reader.ReadBool();
            var hasPos = reader.ReadBool();
            if (hasPos)
                LookedAtBlock = reader.ReadBlockPosProto();
        }
    }
}
