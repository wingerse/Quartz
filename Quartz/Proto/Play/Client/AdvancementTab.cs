using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class AdvancementTab : InPacket
    {
        public ActionEnum Action { get; private set; }
        public string TabId { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Action = (ActionEnum)reader.ReadVarint();
            if (!(Action == ActionEnum.OpenedTab || Action == ActionEnum.ClosedScreen))
            {
                throw new InvalidPacketException(nameof(Action), Action);
            }
            if (Action == ActionEnum.OpenedTab)
                TabId = reader.ReadStringProto(ProtoConsts.MaxStringChars);
        }

        public enum ActionEnum
        {
            OpenedTab,
            ClosedScreen
        }
    }
}
