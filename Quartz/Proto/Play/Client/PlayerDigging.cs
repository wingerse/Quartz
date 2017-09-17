using EncodingLib;
using Quartz.Block;
using Quartz.World;

namespace Quartz.Proto.Play.Client
{
    public sealed class PlayerDigging : InPacket
    {
        public StatusEnum Status { get; private set; }
        public BlockPos Location { get; private set; }
        public Facing Facing { get; private set; }

        public override void Read(PrimitiveReader reader)
        {
            Status = (StatusEnum)reader.ReadVarint();
            if (!(Status == StatusEnum.StartDigging ||
                  Status == StatusEnum.CancelDigging ||
                  Status == StatusEnum.FinishDigging ||
                  Status == StatusEnum.DropItemStack ||
                  Status == StatusEnum.DropItem ||
                  Status == StatusEnum.FinishUseItem ||
                  Status == StatusEnum.SwapItem))
            {
                throw new InvalidPacketException(nameof(Status), Status);
            }
            Location = reader.ReadBlockPosProto();
            var facing = reader.ReadByte();
            Facing = Facing.GetFromValue(facing);
            if (Facing == null)
            {
                throw new InvalidPacketException(nameof(Facing), facing);
            }
        }

        public enum StatusEnum
        {
            StartDigging,
            CancelDigging,
            FinishDigging,
            DropItemStack,
            DropItem,
            FinishUseItem,
            SwapItem
        }
    }
}
