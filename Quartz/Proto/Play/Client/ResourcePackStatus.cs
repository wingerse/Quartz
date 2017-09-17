using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class ResourcePackStatus : InPacket
    {
        public StatusEnum Status { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Status = (StatusEnum)reader.ReadVarint();
            if (!(Status == StatusEnum.SuccessfullyLoaded ||
                  Status == StatusEnum.Declined ||
                  Status == StatusEnum.FailedDownload ||
                  Status == StatusEnum.Accepted))
            {
                throw new InvalidPacketException(nameof(Status), Status);
            }
        }

        public enum StatusEnum
        {
            SuccessfullyLoaded,
            Declined,
            FailedDownload,
            Accepted
        }
    }
}
