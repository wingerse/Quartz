using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class UpdateHealth : OutPacket
    {
        public float Health { get; set; }
        public int Food { get; set; }
        public float FoodSaturation { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteFloat(Health);
            writer.WriteVarint(Food);
            writer.WriteFloat(FoodSaturation);
        }
    }
}
