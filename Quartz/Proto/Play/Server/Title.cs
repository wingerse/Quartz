using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class Title : OutPacket
    {
        public ActionEnum Action { get; set; }

        /// <summary>
        /// Can be null if Action != SetTitle
        /// </summary>
        public ChatRoot TitleText { get; set; }

        /// <summary>
        /// Can be null if Action != SetSubtitle
        /// </summary>
        public ChatRoot SubtitleText { get; set; }

        /// <summary>
        /// Can be null if Action != SetActionBar
        /// </summary>
        public ChatRoot ActionBarText { get; set; }

        public int FadeIn { get; set; }
        public int Stay { get; set; }
        public int FadeOut { get; set; }

        public override void Write(PrimitiveWriter writer)
        {
            switch (Action)
            {
                case ActionEnum.SetTitle:
                    writer.WriteChatRootProto(TitleText);
                    break;
                case ActionEnum.SetSubtitle:
                    writer.WriteChatRootProto(SubtitleText);
                    break;
                case ActionEnum.SetActionBar:
                    writer.WriteChatRootProto(ActionBarText);
                    break;
                case ActionEnum.SetTimes:
                    writer.WriteInt(FadeIn);
                    writer.WriteInt(Stay);
                    writer.WriteInt(FadeOut);
                    break;
                case ActionEnum.Hide:
                case ActionEnum.Reset:
                    break;
            }
        }

        public enum ActionEnum
        {
            SetTitle,
            SetSubtitle,
            SetActionBar,
            SetTimes,
            Hide,
            Reset
        }
    }
}
