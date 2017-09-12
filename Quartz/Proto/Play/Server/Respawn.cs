using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class Respawn : OutPacket
    {
        public const int IdConst = 0x35;

        public Dimension Dimension { get; set; }
        public Difficulty Difficulty { get; set; }
        public Gamemode Gamemode { get; set; }
        public LevelType LevelType { get; set; }
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt((int)Dimension);
            writer.WriteByte((byte)Difficulty);
            writer.WriteByte((byte)Gamemode);
            writer.WriteStringProto(LevelType.Name);
        }
    }
}
