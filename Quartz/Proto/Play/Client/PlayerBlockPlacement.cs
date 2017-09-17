using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Client
{
    public sealed class PlayerBlockPlacement : InPacket
    {
        public BlockPos Location { get; private set; }
        public Facing Facing { get; private set; }
        public Hand Hand { get; private set; }
        public float CursorPosX { get; private set; }
        public float CursorPosY { get; private set; }
        public float CursorPosZ { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Location = reader.ReadBlockPosProto();
            var facing = reader.ReadVarint();
            Facing = Facing.GetFromValue((byte)facing);
            if (Facing == null) 
                throw new InvalidPacketException(nameof(Facing), facing);
            Hand = (Hand)reader.ReadVarint();
            if (!Hand.IsValid())
                throw new InvalidPacketException(nameof(Hand), Hand);
            CursorPosX = reader.ReadFloat();
            CursorPosY = reader.ReadFloat();
            CursorPosZ = reader.ReadFloat();
        }
    }
}
