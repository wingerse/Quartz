using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class EntityAction : InPacket
    {
        public int EntityId { get; private set; }
        public ActionEnum Action { get; private set; }
        public int JumpBoost { get; private set; }

        public override void Read(PrimitiveReader reader)
        {
            EntityId = reader.ReadVarint();
            Action = (ActionEnum)reader.ReadVarint();
            if (!(
                Action == ActionEnum.StartSneaking ||
                Action == ActionEnum.StopSneaking ||
                Action == ActionEnum.LeaveBed ||
                Action == ActionEnum.StartSprinting ||
                Action == ActionEnum.StopSprinting ||
                Action == ActionEnum.StartJumpWithHorse ||
                Action == ActionEnum.StopJumpWithHorse ||
                Action == ActionEnum.OpenHorseInventory ||
                Action == ActionEnum.StartFlyingWithElytra))
            {
                throw new InvalidPacketException(nameof(Action), Action);
            }
            JumpBoost = reader.ReadVarint();
            if (!(JumpBoost >= 0 && JumpBoost <= 100))
            {
                throw new InvalidPacketException(nameof(JumpBoost), JumpBoost);
            }
        }

        public enum ActionEnum
        {
            StartSneaking,
            StopSneaking,
            LeaveBed,
            StartSprinting,
            StopSprinting,
            StartJumpWithHorse,
            StopJumpWithHorse,
            OpenHorseInventory,
            StartFlyingWithElytra
        }
    }
}
