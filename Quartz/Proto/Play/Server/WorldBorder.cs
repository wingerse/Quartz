using EncodingLib;

namespace Quartz.Proto.Play.Server
{
    public sealed class WorldBorder : OutPacket
    {
        public const int IdConst = 0x38;
	
		public World.WorldBorder Border { get; set; }
	    public ActionEnum Action { get; set; }
	
        public override int Id => IdConst;
	
        public override void Write(PrimitiveWriter writer)
        {
			writer.WriteVarint((int)Action);
	        switch (Action)
	        {
				case ActionEnum.SetDiameter:
					writer.WriteDouble(Border.Diameter);
					break;
				case ActionEnum.LerpSize:
					writer.WriteDouble(Border.Diameter);
					writer.WriteDouble(Border.NewDiameter);
					break;
				case ActionEnum.SetCenter:
					writer.WriteDouble(Border.CenterX);
					writer.WriteDouble(Border.CenterZ);
					break;
				case ActionEnum.Initialize:
					writer.WriteDouble(Border.CenterX);
					writer.WriteDouble(Border.CenterZ);
					writer.WriteDouble(Border.Diameter);
					writer.WriteDouble(Border.NewDiameter);
					writer.WriteVarlong(Border.TimeUntilNewDiameter);
					writer.WriteVarint(Border.PortalTeleportBoundary);
					writer.WriteVarint(Border.WarningTime);
					writer.WriteVarint(Border.WarningBlocks);
					break;
				case ActionEnum.SetWarningTime:
					writer.WriteVarint(Border.WarningTime);
					break;
				case ActionEnum.SetWarningBlocks:
					writer.WriteVarint(Border.WarningBlocks);
					break;
	        }
        }

	    public enum ActionEnum
	    {
		    SetDiameter,
		    LerpSize,
		    SetCenter,
		    Initialize,
		    SetWarningTime,
		    SetWarningBlocks
	    }
    }
}
