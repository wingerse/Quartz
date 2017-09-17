using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class SteerVehicle : InPacket
    {
        public float Sideways { get; private set; }
        public float Forward { get; private set; }
        public bool Jump { get; private set; }
        public bool Unmount { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Sideways = reader.ReadFloat();
            Forward = reader.ReadFloat();
            var flags = reader.ReadByte();
            if ((flags & 0x01) != 0) Jump = true;
            if ((flags & 0x02) != 0) Unmount = true;
        }
    }
}
