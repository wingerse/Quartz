using System.Collections.Generic;
using Quartz.Text.Chat;

namespace Quartz.Scoreboard
{
    public sealed class Team
    {
        public string DisplayName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public bool AllowFriendlyFire { get; set; }
        public bool CanSeeInvisTeamMates { get; set; }
        public NameTagVisibilityEnum NameTagVisibility { get; set; }
        public CollisionRuleEnum CollisionRule { get; set; }
        public ChatColor Color { get; set; }
        public List<string> Entities { get; set; }

        public sealed class NameTagVisibilityEnum
        {
            public string Name { get; }
            
            public NameTagVisibilityEnum(string name) => Name = name;

            public static readonly NameTagVisibilityEnum Always = new NameTagVisibilityEnum("always");
            public static readonly NameTagVisibilityEnum HideForOtherTeams = new NameTagVisibilityEnum("hideForOtherTeams");
            public static readonly NameTagVisibilityEnum HideForOwnTeam = new NameTagVisibilityEnum("hideForOwnTeam");
            public static readonly NameTagVisibilityEnum Never = new NameTagVisibilityEnum("never");
        }

        public sealed class CollisionRuleEnum
        {
            public string Name { get; }

            public CollisionRuleEnum(string name) => Name = name;
            
            public static readonly CollisionRuleEnum Always = new CollisionRuleEnum("always");
            public static readonly CollisionRuleEnum PushOtherTeams = new CollisionRuleEnum("pushOtherTeams");
            public static readonly CollisionRuleEnum PushOwnTeam = new CollisionRuleEnum("pushOwnTeam");
            public static readonly CollisionRuleEnum Never = new CollisionRuleEnum("never");
        }
    }
}
