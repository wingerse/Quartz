using System.Collections.Generic;
using System.Linq;

namespace Quartz.World
{
    public sealed class LevelType
    {
        public string Name { get; }

        private LevelType(string name)
        {
            Name = name;
        }

        public static readonly LevelType Default = new LevelType("default");
        public static readonly LevelType Flat = new LevelType("flat");
        public static readonly LevelType LargeBiomes = new LevelType("largeBiomes");
        public static readonly LevelType Amplified = new LevelType("amplified");
        public static readonly LevelType Default11 = new LevelType("default_1_1");

        private static readonly LevelType[] Values = {Default, Flat, LargeBiomes, Amplified, Default};

        private static readonly Dictionary<string, LevelType> FromName;

        static LevelType()
        {
            FromName = Values.ToDictionary(e => e.Name);
        }

        public static LevelType GetFromName(string name) => FromName.TryGetValue(name, out LevelType value) ? value : null;
    }
}
