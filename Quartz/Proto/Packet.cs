using EncodingLib;

namespace Quartz.Proto
{
    public abstract class InPacket
    {
        public abstract void Read(PrimitiveReader reader);
    }
    
    public abstract class OutPacket
    {
        public abstract int Id { get; }
        public abstract void Write(PrimitiveWriter writer);
    }
}
