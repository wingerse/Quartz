using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class ScoreboardObjective : OutPacket
    {
        public string Name { get; set; }
        public Scoreboard.ScoreboardObjective Objective { get; set; }
        public ModeEnum Mode { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(Name);
            writer.WriteByte((byte)Mode);
            if (Mode == ModeEnum.Create || Mode == ModeEnum.UpdateDisplayName)
            {
                writer.WriteStringProto(Objective.DisplayName);
                writer.WriteStringProto(Objective.Type.Name);
            }
        }

        public enum ModeEnum
        {
            Create,
            Remove,
            UpdateDisplayName
        }
    }
}
