using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public class PluginMessage : InPacket
    {
        public string Channel { get; private set; }
        public byte[] Data { get; private set; }

        public override void Read(PrimitiveReader reader)
        {
            Channel = reader.ReadStringProto(20);
            Data = new byte[reader.BaseStream.Length];
            reader.ReadFully(Data, 0, Data.Length);
        }
    }
}
