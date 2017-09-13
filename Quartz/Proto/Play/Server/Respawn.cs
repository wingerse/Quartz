using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class Respawn : OutPacket
    {
        public Dimension Dimension { get; set; }
        public Difficulty Difficulty { get; set; }
        public Gamemode Gamemode { get; set; }
        public LevelType LevelType { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt((int)Dimension);
            writer.WriteByte((byte)Difficulty);
            writer.WriteByte((byte)Gamemode);
            writer.WriteStringProto(LevelType.Name);
        }
    }
}
