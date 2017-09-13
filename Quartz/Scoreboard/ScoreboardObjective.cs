namespace Quartz.Scoreboard
{
    public sealed class ScoreboardObjective
    {
        public string DisplayName { get; set; }
        public TypeEnum Type { get; set; }

        public sealed class TypeEnum
        {
            public string Name { get; }

            private TypeEnum(string name)
            {
                Name = name;
            }
            
            public static readonly TypeEnum Integer = new TypeEnum("integer");
            public static readonly TypeEnum Hearts = new TypeEnum("hearts");
        }
    }
}
