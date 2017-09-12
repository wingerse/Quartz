using System.Collections.Generic;
using EncodingLib;
using Quartz.Entity;
using Quartz.Text.Chat;

namespace Quartz.Proto.Play.Server
{
    public sealed class PlayerListItem : OutPacket
    {
        public const int IdConst = 0x2e;

        public ActionEnum Action { get; set; }
        public List<Player> Players { get; set; }

        public override int Id => IdConst;

        public override void Write(PrimitiveWriter writer)
        {
            writer.WriteVarint((int)Action);
            writer.WriteVarint(Players.Count);
            foreach (var p in Players)
            {
                writer.WriteUuidProto(p.Profile.Id);
                switch (Action)
                {
                    case ActionEnum.AddPlayer:
                        writer.WriteStringProto(p.Profile.Name);
                        writer.WriteVarint(p.Profile.Properties.Length);
                        foreach (var prof in p.Profile.Properties)
                        {
                            writer.WriteStringProto(prof.Name);
                            writer.WriteStringProto(prof.Value);
                            writer.WriteBool(prof.IsSigned);
                            if (prof.IsSigned) writer.WriteStringProto(prof.Signature);
                        }
                        writer.WriteVarint((int)p.Gamemode);
                        writer.WriteVarint(p.Ping);
                        writer.WriteBool(p.DisplayName != null);
                        if (p.DisplayName != null) writer.WriteChatRootProto(p.DisplayName);
                        break;
                    case ActionEnum.UpdateGamemode:
                        writer.WriteVarint((int)p.Gamemode);
                        break;
                    case ActionEnum.UpdateLatency:
                        writer.WriteVarint(p.Ping);
                        break;
                    case ActionEnum.UpdateDisplayName:
                        writer.WriteBool(p.DisplayName != null);
                        if (p.DisplayName != null) writer.WriteChatRootProto(p.DisplayName);
                        break;
                    case ActionEnum.RemovePlayer: // no fields
                        break;
                }
            }
        }

        public enum ActionEnum
        {
            AddPlayer,
            UpdateGamemode,
            UpdateLatency,
            UpdateDisplayName,
            RemovePlayer
        }
    }
}
