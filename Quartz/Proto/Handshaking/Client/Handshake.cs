using EncodingLib;

namespace Quartz.Proto.Handshaking.Client
{
    public sealed class Handshake : InPacket
    {
        public int ProtocolVersion { get; private set; }
        public string ServerAddress { get; private set; }
        public ushort ServerPort { get; private set; }
        public NextStateEnum NextState { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            ProtocolVersion = reader.ReadVarint();
            ServerAddress = reader.ReadStringProto(255);
            ServerPort = reader.ReadUShort();
            NextState = (NextStateEnum)reader.ReadVarint();
            if (NextState != NextStateEnum.Status && NextState != NextStateEnum.Login)
                throw new InvalidPacketException(nameof(NextState), NextState);
        }

        public enum NextStateEnum
        {
            Status = 1,
            Login
        }
    }
}
