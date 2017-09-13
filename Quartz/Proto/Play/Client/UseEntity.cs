using EncodingLib;
using Quartz.Math;

namespace Quartz.Proto.Play.Client
{
    public sealed class UseEntity : InPacket
    {
        public int TargetEntityId { get; private set; }
        public TypeEnum Type { get; private set; }
        public Vec3 TargetPos { get; private set; }
        public Hand Hand { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            TargetEntityId = reader.ReadVarint();
            Type = (TypeEnum)reader.ReadVarint();
            if (!(Type == TypeEnum.Interact || Type == TypeEnum.Attack || Type == TypeEnum.InteractAt))
                throw new InvalidPacketException(nameof(Type), Type);
            if (Type == TypeEnum.InteractAt)
            {
                TargetPos = new Vec3(reader.ReadFloat(), reader.ReadFloat(), reader.ReadFloat());
            }
            if (Type == TypeEnum.Interact || Type == TypeEnum.InteractAt)
            {
                Hand = (Hand)reader.ReadVarint();
                if (!Hand.IsValid()) 
                    throw new InvalidPacketException(nameof(Hand), Hand);
            }
        }

        public enum TypeEnum
        {
            Interact,
            Attack,
            InteractAt
        }
    }
}
