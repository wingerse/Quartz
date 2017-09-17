using System.Collections.Generic;
using System.Linq;

namespace Quartz.Block
{
    public sealed class Facing
    {
        public byte Value { get; }

        private Facing(byte value) => Value = value;
        
        public static readonly Facing Bottom = new Facing(0);
        public static readonly Facing Top = new Facing(1);
        public static readonly Facing North = new Facing(2);
        public static readonly Facing South = new Facing(3);
        public static readonly Facing West = new Facing(4);
        public static readonly Facing East = new Facing(5);

        private static readonly Facing[] Values = {Bottom, Top, North, South, West, East};
        
        private static readonly Dictionary<byte, Facing> FromValue;

        static Facing()
        {
            FromValue = Values.ToDictionary(e => e.Value);
        }

        /// <summary>
        /// Gets Facing from its value. Returns it, or null if there is no facing with given value.
        /// </summary>
        public static Facing GetFromValue(byte value) => FromValue.TryGetValue(value, out Facing facing) ? facing : null;
    }
}
