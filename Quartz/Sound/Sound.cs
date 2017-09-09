namespace Quartz.Sound
{
    public sealed class Sound
    {
        public int Id { get; }
        public string Name { get; }
        
        public Sound(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
