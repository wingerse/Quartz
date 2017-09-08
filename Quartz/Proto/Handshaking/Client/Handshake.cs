using EncodingLib;

namespace Quartz.Proto.Handshaking.Client
{
    public sealed class Handshake : IInPacket
    {
        public const int Id = 0;
        
        public int ProtocolVersion { get; set; }
        public string ServerAddress { get; set; }
        public ushort ServerPort { get; set; }
        public NextStateEnum NextState { get; set; }
        
        public void Read(PrimitiveReader reader)
        {
            ProtocolVersion = reader.ReadVarint();
            ServerAddress = reader.ReadStringProto(255);
            ServerPort = reader.ReadUShort();
            NextState = (NextStateEnum)reader.ReadVarint();
            if (NextState != NextStateEnum.Status || NextState != NextStateEnum.Login)
                throw new InvalidPacketException(nameof(NextState), NextState);
        }

        public enum NextStateEnum
        {
            Status = 1,
            Login
        }
    }
}
