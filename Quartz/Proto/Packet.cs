using EncodingLib;

namespace Quartz.Proto
{
    public abstract class InPacket
    {
        internal InPacket() {}
        public abstract void Read(PrimitiveReader reader);
    }

    public abstract class OutPacket
    {
        internal OutPacket() {}
        public abstract void Write(PrimitiveWriter writer);
    }
}
