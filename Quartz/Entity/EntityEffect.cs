using System.Collections.Generic;
using System.Linq;

namespace Quartz.Entity
{
    public sealed class EntityEffect
    {
        public byte Id { get; }
        public string Name { get; }

        private EntityEffect(byte id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly EntityEffect Speed = new EntityEffect(1, "speed");
        public static readonly EntityEffect Slowness = new EntityEffect(2, "slowness");
        public static readonly EntityEffect Haste = new EntityEffect(3, "haste");
        public static readonly EntityEffect MiningFatigue = new EntityEffect(4, "mining_fatigue");
        public static readonly EntityEffect Strength = new EntityEffect(5, "strength");
        public static readonly EntityEffect InstantHealth = new EntityEffect(6, "instant_health");
        public static readonly EntityEffect InstantDamage = new EntityEffect(7, "instant_damage");
        public static readonly EntityEffect JumpBoost = new EntityEffect(8, "jump_boost");
        public static readonly EntityEffect Nausea = new EntityEffect(9, "nausea");
        public static readonly EntityEffect Regeneration = new EntityEffect(10, "regeneration");
        public static readonly EntityEffect Resistance = new EntityEffect(11, "resistance");
        public static readonly EntityEffect FireResistance = new EntityEffect(12, "fire_resistance");
        public static readonly EntityEffect WaterBreathing = new EntityEffect(13, "water_breathing");
        public static readonly EntityEffect Invisibility = new EntityEffect(14, "invisibility");
        public static readonly EntityEffect Blindness = new EntityEffect(15, "blindness");
        public static readonly EntityEffect NightVision = new EntityEffect(16, "night_vision");
        public static readonly EntityEffect Hunger = new EntityEffect(17, "hunger");
        public static readonly EntityEffect Weakness = new EntityEffect(18, "weakness");
        public static readonly EntityEffect Poison = new EntityEffect(19, "poison");
        public static readonly EntityEffect Wither = new EntityEffect(20, "wither");
        public static readonly EntityEffect HealthBoost = new EntityEffect(21, "health_boost");
        public static readonly EntityEffect Absorption = new EntityEffect(22, "absorption");
        public static readonly EntityEffect Saturation = new EntityEffect(23, "saturation");
        public static readonly EntityEffect Glowing = new EntityEffect(24, "glowing");
        public static readonly EntityEffect Levitation = new EntityEffect(25, "levitation");
        public static readonly EntityEffect Luck = new EntityEffect(26, "luck");
        public static readonly EntityEffect Unluck = new EntityEffect(27, "unluck");

        private static readonly EntityEffect[] Values =
        {
            Speed, Slowness, Haste, MiningFatigue, Strength, InstantHealth, InstantDamage, JumpBoost, Nausea, Regeneration, Resistance, FireResistance,
            WaterBreathing, Invisibility, Blindness, NightVision, Hunger, Weakness, Poison, Wither, HealthBoost, Absorption, Saturation, Glowing, Levitation,
            Luck, Unluck
        };

        private static readonly Dictionary<byte, EntityEffect> FromId;
        private static readonly Dictionary<string, EntityEffect> FromName;

        static EntityEffect()
        {
            FromId = Values.ToDictionary(e => e.Id);
            FromName = Values.ToDictionary(e => e.Name);
        }

        /// <summary>
        /// Gets EntityEffect from its id. Returns it, or null if there is no EntityEffect with given id.
        /// </summary>
        public static EntityEffect GetFromId(byte id) => FromId.TryGetValue(id, out EntityEffect value) ? value : null;
        
        /// <summary>
        /// Gets EntityEffect from its name. Returns it, or null if there is no EntityEffect with given name.
        /// </summary>
        public static EntityEffect GetFromName(string name) => FromName.TryGetValue(name, out EntityEffect value) ? value : null;

    }
}
