namespace Quartz.World
{
    public sealed class WorldBorder
    {
        public double Diameter { get; set; }
        public double NewDiameter { get; set; }
        public long TimeUntilNewDiameter { get; set; }
        public double CenterX { get; set; }
        public double CenterZ { get; set; }
        public int PortalTeleportBoundary { get; set; }
        public int WarningTime { get; set; }
        public int WarningBlocks { get; set; }
    }
}
