using EncodingLib;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class CombatEvent : OutPacket
    {
        public EventEnum Event { get; set; }
        
        public override void Write(PrimitiveWriter writer)
        {
            switch (Event)
            {
                case EventEnum.EnterCombat _:
                    writer.WriteVarint(0);
                    break;
                case EventEnum.EndCombat x:
                    writer.WriteVarint(1);
                    writer.WriteVarint(x.Duration);
                    writer.WriteInt(x.EntityId);
                    break;
                case EventEnum.EntityDead x:
                    writer.WriteVarint(2);
                    writer.WriteVarint(x.PlayerId);
                    writer.WriteInt(x.EntityId);
                    writer.WriteChatRootProto(x.Message);
                    break;
            }
        }

        public abstract class EventEnum
        {
            private EventEnum()
            {
            }

            public sealed class EnterCombat : EventEnum
            {
            }

            public sealed class EndCombat : EventEnum
            {
                public int Duration { get; set; }
                public int EntityId { get; set; }
            }

            public sealed class EntityDead : EventEnum
            {
                public int PlayerId { get; set; }
                public int EntityId { get; set; }
                public ChatRoot Message { get; set; }
            }
        }
    }
}
