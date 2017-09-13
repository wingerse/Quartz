using System;
using System.Collections.Generic;

namespace Quartz.Proto
{
    public static class Packets
    {
        /// <summary>
        /// Type -> id mappings for all OutPackets.
        /// </summary>
        private static readonly Dictionary<Type, int> OutPackets = new Dictionary<Type, int>
        {
            [typeof(Login.Server.Disconnect)] = 0x00,
            [typeof(Login.Server.LoginSuccess)] = 0x02,
            [typeof(Login.Server.SetCompression)] = 0x03,

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
            [typeof(Play.Server.EntityEffect)] = 0x4f,

            [typeof(Status.Server.Response)] = 0x00,
            [typeof(Status.Server.Pong)] = 0x01
        };

        public static int GetId<T>()
            where T : OutPacket
        {
            return OutPackets[typeof(T)];
        }
    }
}
