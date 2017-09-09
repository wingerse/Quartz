namespace Quartz.World
{
    public struct ChunkPos
    {
        public int X { get; }
        public int Z { get; }
        
        public ChunkPos(int x, int z)
        {
            X = x;
            Z = z;
        }
    }
}
