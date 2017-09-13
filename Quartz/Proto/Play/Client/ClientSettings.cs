using EncodingLib;

namespace Quartz.Proto.Play.Client
{
    public sealed class ClientSettings : InPacket
    {
        public string Locale { get; private set; }
        public byte ViewDistance { get; private set; }
        public ChatModeEnum ChatMode { get; private set; }
        public bool ChatColors { get; private set; }
        public bool CapeEnabled { get; private set; }
        public bool JacketEnabled { get; private set; }
        public bool LeftSleeveEnabled { get; private set; }
        public bool RightSleeveEnabled { get; private set; }
        public bool LeftPantsLegEnabled { get; private set; }
        public bool RightPantsLegEnabled { get; private set; }
        public bool HatEnabled { get; private set; }
        public HandSide MainHand { get; private set; }
        
        public override void Read(PrimitiveReader reader)
        {
            Locale = reader.ReadStringProto(16);
            ViewDistance = reader.ReadByte();
            ChatMode = (ChatModeEnum)reader.ReadVarint();
            if (!(ChatMode == ChatModeEnum.Enabled || ChatMode == ChatModeEnum.CommandsOnly || ChatMode == ChatModeEnum.Hidden))
                throw new InvalidPacketException(nameof(ChatMode), ChatMode);
            var mask = reader.ReadByte();
            if ((mask & 0x01) != 0) CapeEnabled = true;
            if ((mask & 0x02) != 0) JacketEnabled = true;
            if ((mask & 0x04) != 0) LeftSleeveEnabled = true;
            if ((mask & 0x08) != 0) RightSleeveEnabled = true;
            if ((mask & 0x10) != 0) LeftPantsLegEnabled = true;
            if ((mask & 0x20) != 0) RightPantsLegEnabled = true;
            if ((mask & 0x40) != 0) HatEnabled = true;
            MainHand = (HandSide)reader.ReadVarint();
            if (!MainHand.IsValid())
                throw new InvalidPacketException(nameof(MainHand), MainHand);
        }

        public enum ChatModeEnum
        {
            Enabled,
            CommandsOnly,
            Hidden
        }
    }
}
