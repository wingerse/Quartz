using EncodingLib;

namespace Quartz.Proto
{
    public interface IOutPacket
    {
        int Id { get; }
        void Write(PrimitiveWriter writer);
    }
}
