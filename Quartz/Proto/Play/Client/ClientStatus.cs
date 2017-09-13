using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class ClientStatus : InPacket
    {
        public ActionEnum Action { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Action = (ActionEnum)reader.ReadVarint();
            if (!(Action == ActionEnum.PerformRespawn || Action == ActionEnum.RequestStats))
            {
                throw new InvalidPacketException(nameof(Action), Action);
            }
        }

        public enum ActionEnum
        {
            PerformRespawn,
            RequestStats
        }
        
    }
}
