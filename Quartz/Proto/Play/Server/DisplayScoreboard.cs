using EncodingLib;
using Quartz.Scoreboard;

namespace Quartz.Proto.Play.Server
{
    public sealed class DisplayScoreboard : OutPacket
    {
        public const int IdConst = 0x3b;
	
		public ScoreboardPosition Position { get; set; }
	    public string ScoreName { get; set; }
	
        public override int Id => IdConst;
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteByte((byte)Position);
	        writer.WriteStringProto(ScoreName);
        }
    }
}
