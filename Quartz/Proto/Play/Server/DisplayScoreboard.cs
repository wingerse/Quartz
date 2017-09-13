using EncodingLib;
using Quartz.Scoreboard;

namespace Quartz.Proto.Play.Server
{
    public sealed class DisplayScoreboard : OutPacket
    {
		public ScoreboardPosition Position { get; set; }
	    public string ScoreName { get; set; }
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteByte((byte)Position);
	        writer.WriteStringProto(ScoreName);
        }
    }
}
