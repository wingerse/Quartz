using EncodingLib;
using Quartz.World;

namespace Quartz.Proto.Play.Server
{
    public sealed class JoinGame : OutPacket
    {
        public const int IdConst = 0x23;

        public int EntityId { get; set; }
        public Gamemode Gamemode { get; set; }
        public bool IsHardcore { get; set; }
        public Dimension Dimension { get; set; }
        public Difficulty Difficulty { get; set; }
        public byte MaxPlayers { get; set; }
        public LevelType LevelType { get; set; }
        public bool ReducedDebugInfo { get; set; }
        
        
        public override int Id => IdConst;
        
        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteInt(EntityId);
            var gamemode = (byte)Gamemode;
            if (IsHardcore) gamemode |= 0x8;
            writer.WriteByte(gamemode);
            writer.WriteInt((int)Dimension);
            writer.WriteByte((byte)Difficulty);
            writer.WriteByte(MaxPlayers);
            writer.WriteStringProto(LevelType.Name);
            writer.WriteBool(ReducedDebugInfo);
        }
    }
}
