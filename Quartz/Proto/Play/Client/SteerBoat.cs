using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class SteerBoat : InPacket
    {
        public bool RightPaddleTurning { get; private set; }
        public bool LeftPaddleTurning { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            RightPaddleTurning = reader.ReadBool();
            LeftPaddleTurning = reader.ReadBool();
        }
    }
}
