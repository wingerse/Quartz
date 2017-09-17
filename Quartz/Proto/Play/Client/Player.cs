using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class Player : InPacket
    {
        public bool OnGround { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            OnGround = reader.ReadBool();
        }
    }
}
