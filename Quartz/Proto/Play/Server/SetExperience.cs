using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class SetExperience : OutPacket
    {
        public float ExperienceBar { get; set; }
        public int Level { get; set; }
        public int TotalExperience { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteFloat(ExperienceBar);
            writer.WriteVarint(Level);
            writer.WriteVarint(TotalExperience);
        }
    }
}
