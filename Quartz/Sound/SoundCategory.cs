namespace Quartz.Sound
{
    public sealed class SoundCategory
    {
        public int Id { get; }
        public string Name { get; }

        private SoundCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public static readonly SoundCategory Master = new SoundCategory(0, "master");
        public static readonly SoundCategory Music = new SoundCategory(0, "music");
        public static readonly SoundCategory Records = new SoundCategory(0, "record");
        public static readonly SoundCategory Weather = new SoundCategory(0, "weather");
        public static readonly SoundCategory Blocks = new SoundCategory(0, "block");
        public static readonly SoundCategory Hostile = new SoundCategory(0, "hostile");
        public static readonly SoundCategory Neutral = new SoundCategory(0, "neutral");
        public static readonly SoundCategory Players = new SoundCategory(0, "player");
        public static readonly SoundCategory Ambient = new SoundCategory(0, "ambient");
        public static readonly SoundCategory Voice = new SoundCategory(0, "voice");
    }
}
