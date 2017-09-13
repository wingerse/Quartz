using EncodingLib;
using Quartz.Scoreboard;

namespace Quartz.Proto.Play.Server
{
    public sealed class Teams : OutPacket
    {
        public string TeamName { get; set; }
        public ModeEnum Mode { get; set; }
        public Team Team { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteStringProto(TeamName);
            writer.WriteByte((byte)Mode);
            if (Mode == ModeEnum.Create || Mode == ModeEnum.UpdateInfo)
            {
                writer.WriteStringProto(Team.DisplayName);
                writer.WriteStringProto(Team.Prefix);
                writer.WriteStringProto(Team.Suffix);
                byte x = 0;
                if (Team.AllowFriendlyFire) x |= 0x01;
                if (Team.CanSeeInvisTeamMates) x |= 0x02;
                writer.WriteByte(x);
                writer.WriteStringProto(Team.NameTagVisibility.Name);
                writer.WriteStringProto(Team.CollisionRule.Name);
                writer.WriteSByte(Team.Color.Numeric);
            }

            if (Mode == ModeEnum.Create || Mode == ModeEnum.AddPlayers || Mode == ModeEnum.RemovePlayers)
            {
                writer.WriteVarint(Team.Entities.Count);
                foreach (var e in Team.Entities)
                {
                    writer.WriteStringProto(e);
                }
            }
        }

        public enum ModeEnum
        {
            Create,
            Remove,
            UpdateInfo,
            AddPlayers,
            RemovePlayers
        }
    }
}
