using EncodingLib;

namespace Quartz.Proto
{
    public interface IInPacket
    {
        void Read(PrimitiveReader reader);
    }
}
