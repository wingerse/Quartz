using System;
using System.Collections.Generic;
using EncodingLib;

namespace Quartz.Proto
{
    public abstract class InPacket
    {
        internal InPacket()
        {
        }

        public abstract void Read(PrimitiveReader reader);

        private static readonly Dictionary<State, Dictionary<int, Func<InPacket>>> Mappings = new Dictionary<State, Dictionary<int, Func<InPacket>>>
        {
            [State.Handshaking] = new Dictionary<int, Func<InPacket>>
            {
                [0] = () => new Handshaking.Client.Handshake()
            },
            [State.Login] = new Dictionary<int, Func<InPacket>>
            {
                [0] = () => new Login.Client.LoginStart()
            },
            [State.Play] = new Dictionary<int, Func<InPacket>>
            {
                [0x00] = () => new Play.Client.TeleportConfirm(),
                [0x01] = () => new Play.Client.TabComplete(),
                [0x02] = () => new Play.Client.ChatMessage(),
                [0x03] = () => new Play.Client.ClientStatus(),
                [0x04] = () => new Play.Client.ClientSettings(),
                [0x05] = () => new Play.Client.ConfirmTransaction(),
                [0x06] = () => new Play.Client.EnchantItem(),
                [0x07] = () => new Play.Client.ClickWindow(),
                [0x08] = () => new Play.Client.CloseWindow(),
                [0x09] = () => new Play.Client.PluginMessage(),
                [0x0a] = () => new Play.Client.UseEntity(),
                [0x0b] = () => new Play.Client.KeepAlive(),
                [0x0c] = () => new Play.Client.Player(),
                [0x0d] = () => new Play.Client.PlayerPosition(),
                [0x0e] = () => new Play.Client.PlayerPositionAndLook(),
                [0x0f] = () => new Play.Client.PlayerLook(),
                [0x10] = () => new Play.Client.VehicleMove(),
                [0x11] = () => new Play.Client.SteerBoat(),
                [0x12] = () => new Play.Client.CraftRecipeRequest(),
                [0x13] = () => new Play.Client.PlayerAbilities(),
                [0x14] = () => new Play.Client.PlayerDigging(),
                [0x15] = () => new Play.Client.EntityAction(),
                [0x16] = () => new Play.Client.SteerVehicle(),
                [0x17] = () => new Play.Client.CraftingBookData(),
                [0x18] = () => new Play.Client.ResourcePackStatus(),
                [0x19] = () => new Play.Client.AdvancementTab(),
                [0x1a] = () => new Play.Client.HeldItemChange(),
                [0x1b] = () => new Play.Client.CreativeInventoryAction(),
                [0x1c] = () => new Play.Client.UpdateSign(),
                [0x1d] = () => new Play.Client.Animation(),
                [0x1e] = () => new Play.Client.Spectate(),
                [0x1f] = () => new Play.Client.PlayerBlockPlacement(),
                [0x20] = () => new Play.Client.UseItem()
            },
            [State.Status] = new Dictionary<int, Func<InPacket>>
            {
                [0] = () => new Status.Client.Request(),
                [1] = () => new Status.Client.Ping()
            }
        };

        /// <summary>
        /// Gets a new packet based on state and id.
        /// </summary>
        /// <exception cref="UnknownPacketException">if id is not valid for this state</exception>
        public static InPacket GetNewPacket(State state, int id)
        {
            var dic = Mappings[state];
            if (!dic.TryGetValue(id, out Func<InPacket> func))
            {
                throw new UnknownPacketException(id);
            }
            return func();
        }
    }

    public abstract class OutPacket
    {
        internal OutPacket()
        {
        }

        public abstract void Write(PrimitiveWriter writer);

        private static readonly Dictionary<State, Dictionary<Type, int>> Mappings = new Dictionary<State, Dictionary<Type, int>>
        {
            [State.Login] = new Dictionary<Type, int>
            {
                [typeof(Login.Server.Disconnect)] = 0x00,
                [typeof(Login.Server.LoginSuccess)] = 0x02,
                [typeof(Login.Server.SetCompression)] = 0x03
            },
            [State.Play] = new Dictionary<Type, int>
            {
                [typeof(Play.Server.SpawnObject)] = 0x00,
                [typeof(Play.Server.SpawnExperienceOrb)] = 0x01,
                [typeof(Play.Server.SpawnGlobalEntity)] = 0x02,
                [typeof(Play.Server.SpawnMob)] = 0x03,
                [typeof(Play.Server.SpawnPainting)] = 0x04,
                [typeof(Play.Server.SpawnPlayer)] = 0x05,
                [typeof(Play.Server.Animation)] = 0x06,
                [typeof(Play.Server.Statistics)] = 0x07,
                [typeof(Play.Server.BlockBreakAnimation)] = 0x08,
                [typeof(Play.Server.UpdateBlockEntity)] = 0x09,
                [typeof(Play.Server.BlockAction)] = 0x0a,
                [typeof(Play.Server.BlockChange)] = 0x0b,
                [typeof(Play.Server.BossBar)] = 0x0c,
                [typeof(Play.Server.ServerDifficulty)] = 0x0d,
                [typeof(Play.Server.TabComplete)] = 0x0e,
                [typeof(Play.Server.ChatMessage)] = 0x0f,
                [typeof(Play.Server.MultiBlockChange)] = 0x10,
                [typeof(Play.Server.ConfirmTransaction)] = 0x11,
                [typeof(Play.Server.CloseWindow)] = 0x12,
                [typeof(Play.Server.OpenWindow)] = 0x13,
                [typeof(Play.Server.WindowItems)] = 0x14,
                [typeof(Play.Server.WindowProperty)] = 0x15,
                [typeof(Play.Server.SetSlot)] = 0x16,
                [typeof(Play.Server.SetCooldown)] = 0x17,
                [typeof(Play.Server.NamedSoundEffect)] = 0x19,
                [typeof(Play.Server.Disconnect)] = 0x1a,
                [typeof(Play.Server.EntityStatus)] = 0x1b,
                [typeof(Play.Server.Explosion)] = 0x1c,
                [typeof(Play.Server.UnloadChunk)] = 0x1d,
                [typeof(Play.Server.ChangeGameState)] = 0x1e,
                [typeof(Play.Server.KeepAlive)] = 0x1f,
                [typeof(Play.Server.ChunkData)] = 0x20,
                [typeof(Play.Server.Effect)] = 0x21,
                [typeof(Play.Server.DisplayParticle)] = 0x22,
                [typeof(Play.Server.JoinGame)] = 0x23,
                [typeof(Play.Server.Map)] = 0x24,
                [typeof(Play.Server.Entity)] = 0x25,
                [typeof(Play.Server.EntityRelativeMove)] = 0x26,
                [typeof(Play.Server.EntityLookAndRelativeMove)] = 0x27,
                [typeof(Play.Server.EntityLook)] = 0x28,
                [typeof(Play.Server.VehicleMove)] = 0x29,
                [typeof(Play.Server.OpenSignEditor)] = 0x2a,
                [typeof(Play.Server.CraftRecipeResponse)] = 0x2b,
                [typeof(Play.Server.PlayerAbilities)] = 0x2c,
                [typeof(Play.Server.CombatEvent)] = 0x2d,
                [typeof(Play.Server.PlayerListItem)] = 0x2e,
                [typeof(Play.Server.PlayerPositionAndLook)] = 0x2f,
                [typeof(Play.Server.UseBed)] = 0x30,
                [typeof(Play.Server.UnlockRecipes)] = 0x31,
                [typeof(Play.Server.DestroyEntities)] = 0x32,
                [typeof(Play.Server.RemoveEntityEffect)] = 0x33,
                [typeof(Play.Server.ResourcePackSend)] = 0x34,
                [typeof(Play.Server.Respawn)] = 0x35,
                [typeof(Play.Server.EntityHeadLook)] = 0x36,
                [typeof(Play.Server.SelectAdvancementTab)] = 0x37,
                [typeof(Play.Server.WorldBorder)] = 0x38,
                [typeof(Play.Server.Camera)] = 0x39,
                [typeof(Play.Server.HeldItemChange)] = 0x3a,
                [typeof(Play.Server.DisplayScoreboard)] = 0x3b,
                [typeof(Play.Server.EntityMetadata)] = 0x3c,
                [typeof(Play.Server.AttachEntity)] = 0x3d,
                [typeof(Play.Server.EntityVelocity)] = 0x3e,
                [typeof(Play.Server.EntityEquipment)] = 0x3f,
                [typeof(Play.Server.SetExperience)] = 0x40,
                [typeof(Play.Server.UpdateHealth)] = 0x41,
                [typeof(Play.Server.ScoreboardObjective)] = 0x42,
                [typeof(Play.Server.SetPassengers)] = 0x43,
                [typeof(Play.Server.Teams)] = 0x44,
                [typeof(Play.Server.UpdateScore)] = 0x45,
                [typeof(Play.Server.SpawnPosition)] = 0x46,
                [typeof(Play.Server.TimeUpdate)] = 0x47,
                [typeof(Play.Server.Title)] = 0x48,
                [typeof(Play.Server.SoundEffect)] = 0x49,
                [typeof(Play.Server.PlayerListHeaderAndFooter)] = 0x4a,
                [typeof(Play.Server.CollectItem)] = 0x4b,
                [typeof(Play.Server.EntityTeleport)] = 0x4c,
                [typeof(Play.Server.Advancements)] = 0x4d,
                [typeof(Play.Server.EntityProperties)] = 0x4e,
                [typeof(Play.Server.EntityEffect)] = 0x4f
            },
            [State.Status] = new Dictionary<Type, int>
            {
                [typeof(Status.Server.Response)] = 0x00,
                [typeof(Status.Server.Pong)] = 0x01
            }
        };

        public static int GetId(State state, OutPacket packet)
        {
            return Mappings[state][packet.GetType()];
        }
    }
}
