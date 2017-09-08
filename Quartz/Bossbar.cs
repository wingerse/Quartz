using System;
using Quartz.Text.Chat;

namespace Quartz
{
    public sealed class Bossbar
    {
        public Guid Uuid { get; }
        public ChatRoot Title { get; set; }
        public float Health { get; set; }
        public ColorEnum Color { get; set; }
        public DivisionEnum Division { get; set; }
        public bool ShouldDarkenSky { get; set; }
        public bool IsDragonBar { get; set; }

        public Bossbar(ChatRoot title)
        {
            Uuid = Guid.NewGuid();
            Title = title;
        }

        public enum ColorEnum
        {
            Pink,
            Blue,
            Red,
            Green,
            Yellow,
            Purple,
            White
        }

        public enum DivisionEnum
        {
            None,
            Notch6,
            Notch10,
            Notch12,
            Notch20
        }
    }
}
