namespace Quartz
{
    public sealed class Painting
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        private Painting(string name, int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Name = name;
        }

        public static readonly Painting Kebab = new Painting("Kebab", 0, 0, 16, 16);
        public static readonly Painting Aztec = new Painting("Aztec", 16, 0, 16, 16);
        public static readonly Painting Alban = new Painting("Alban", 32, 0, 16, 16);
        public static readonly Painting Aztec2 = new Painting("Aztec2", 48, 0, 16, 16);
        public static readonly Painting Bomb = new Painting("Bomb", 64, 0, 16, 16);
        public static readonly Painting Plant = new Painting("Plant", 80, 0, 16, 16);
        public static readonly Painting Wasteland = new Painting("Wasteland", 96, 0, 16, 16);
        public static readonly Painting Pool = new Painting("Pool", 0, 32, 32, 16);
        public static readonly Painting Courbet = new Painting("Courbet", 32, 32, 32, 16);
        public static readonly Painting Sea = new Painting("Sea", 64, 32, 32, 16);
        public static readonly Painting Sunset = new Painting("Sunset", 96, 32, 32, 16);
        public static readonly Painting Creebet = new Painting("Creebet", 128, 32, 32, 16);
        public static readonly Painting Wanderer = new Painting("Wanderer", 0, 64, 16, 32);
        public static readonly Painting Graham = new Painting("Graham", 16, 64, 16, 32);
        public static readonly Painting Match = new Painting("Match", 0, 128, 32, 32);
        public static readonly Painting Bust = new Painting("Bust", 32, 128, 32, 32);
        public static readonly Painting Stage = new Painting("Stage", 64, 128, 32, 32);
        public static readonly Painting Void = new Painting("Void", 96, 128, 32, 32);
        public static readonly Painting SkullAndRoses = new Painting("SkullAndRoses", 128, 128, 32, 32);
        public static readonly Painting Wither = new Painting("Wither", 160, 128, 32, 32);
        public static readonly Painting Fighters = new Painting("Fighters", 0, 96, 64, 32);
        public static readonly Painting Pointer = new Painting("Pointer", 0, 192, 64, 64);
        public static readonly Painting Pigscene = new Painting("Pigscene", 64, 192, 64, 64);
        public static readonly Painting BurningSkull = new Painting("BurningSkull", 128, 192, 64, 64);
        public static readonly Painting Skeleton = new Painting("Skeleton", 192, 64, 64, 48);
        public static readonly Painting DonkeyKong = new Painting("DonkeyKong", 192, 112, 64, 48);
    }
}
