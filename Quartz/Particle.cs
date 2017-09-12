using System.Collections.Generic;
using System.Linq;
using Quartz.Block;
using Quartz.Item;

namespace Quartz
{
    public class Particle
    {
        public int Id { get; }
        public string Name { get; }

        private Particle(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Particle Explosion = new Particle(0, "explode");
        public static readonly Particle LargeExplosion = new Particle(1, "largeexplode");
        public static readonly Particle HugeExplosion = new Particle(2, "hugeexplosion");
        public static readonly Particle FireworksSpark = new Particle(3, "fireworksSpark");
        public static readonly Particle Bubble = new Particle(4, "bubble");
        public static readonly Particle Splash = new Particle(5, "splash");
        public static readonly Particle Wake = new Particle(6, "wake");
        public static readonly Particle Suspended = new Particle(7, "suspended");
        public static readonly Particle DepthSuspend = new Particle(8, "depthsuspend");
        public static readonly Particle Crit = new Particle(9, "crit");
        public static readonly Particle MagicCrit = new Particle(10, "magicCrit");
        public static readonly Particle Smoke = new Particle(11, "smoke");
        public static readonly Particle Largesmoke = new Particle(12, "largesmoke");
        public static readonly Particle Spell = new Particle(13, "spell");
        public static readonly Particle InstantSpell = new Particle(14, "instantSpell");
        public static readonly Particle MobSpell = new Particle(15, "mobSpell");
        public static readonly Particle MobSpellAmbient = new Particle(16, "mobSpellAmbient");
        public static readonly Particle WitchMagic = new Particle(17, "witchMagic");
        public static readonly Particle DripWater = new Particle(18, "dripWater");
        public static readonly Particle DripLava = new Particle(19, "dripLava");
        public static readonly Particle AngryVillager = new Particle(20, "angryVillager");
        public static readonly Particle HappyVillager = new Particle(21, "happyVillager");
        public static readonly Particle TownAura = new Particle(22, "townaura");
        public static readonly Particle Note = new Particle(23, "note");
        public static readonly Particle Portal = new Particle(24, "portal");
        public static readonly Particle EnchantmentTable = new Particle(25, "enchantmenttable");
        public static readonly Particle Flame = new Particle(26, "flame");
        public static readonly Particle Lava = new Particle(27, "lava");
        public static readonly Particle FootStep = new Particle(28, "footstep");
        public static readonly Particle Cloud = new Particle(29, "cloud");
        public static readonly Particle RedDust = new Particle(30, "reddust");
        public static readonly Particle SnowballPoof = new Particle(31, "snowballpoof");
        public static readonly Particle SnowShovel = new Particle(32, "snowshovel");
        public static readonly Particle Slime = new Particle(33, "slime");
        public static readonly Particle Heart = new Particle(34, "heart");
        public static readonly Particle Barrier = new Particle(35, "barrier");
        public static readonly ItemCrackClass ItemCrack = new ItemCrackClass(36, "iconcrack");
        public static readonly BlockParticleClass BlockCrack = new BlockParticleClass(37, "blockcrack");
        public static readonly BlockParticleClass BlockDust = new BlockParticleClass(38, "blockdust");
        public static readonly Particle Droplet = new Particle(39, "droplet");
        public static readonly Particle Take = new Particle(40, "take");
        public static readonly Particle MobAppearance = new Particle(41, "mobappearance");
        public static readonly Particle DragonBreath = new Particle(42, "dragonbreath");
        public static readonly Particle EndRod = new Particle(43, "endRod");
        public static readonly Particle DamageIndicator = new Particle(44, "damageIndicator");
        public static readonly Particle SweepAttack = new Particle(45, "sweepAttack");
        public static readonly BlockParticleClass FallingDust = new BlockParticleClass(46, "fallingdust");
        public static readonly Particle Totem = new Particle(47, "totem");
        public static readonly Particle Spit = new Particle(48, "spit");

        private static readonly Particle[] Values = {
            Explosion, LargeExplosion, HugeExplosion, FireworksSpark, Bubble, Splash, Wake, Suspended, DepthSuspend, Crit, MagicCrit, Smoke, Largesmoke, Spell,
            InstantSpell, MobSpell, MobSpellAmbient, WitchMagic, DripWater, DripLava, AngryVillager, HappyVillager, TownAura, Note, Portal, EnchantmentTable,
            Flame, Lava, FootStep, Cloud, RedDust, SnowballPoof, SnowShovel, Slime, Heart, Barrier, ItemCrack, BlockCrack, BlockDust, Droplet, Take,
            MobAppearance, DragonBreath, EndRod, DamageIndicator, SweepAttack, FallingDust, Totem, Spit
        };

        private static readonly Dictionary<int, Particle> FromId;
        private static readonly Dictionary<string, Particle> FromName;

        static Particle()
        {
            FromId = Values.ToDictionary(e => e.Id);
            FromName = Values.ToDictionary(e => e.Name);
        }

        /// <summary>
        /// Gets particle from its id. Returns it, or null if there is no particle with given id.
        /// </summary>
        public static Particle GetFromId(int id) => FromId.TryGetValue(id, out Particle value) ? value : null;
        
        /// <summary>
        /// Gets particle from its name. Returns it, or null if there is no particle with given name.
        /// </summary>
        public static Particle GetFromName(string name) => FromName.TryGetValue(name, out Particle value) ? value : null;
        
        public class ItemCrackClass : Particle
        {
            internal ItemCrackClass(int id, string name) : base(id, name)
            {
            }

            public int[] GetData(ItemStack param)
            {
                return new int[] {param.Item.Id, param.Damage};
            }
        }

        public class BlockParticleClass : Particle
        {
            internal BlockParticleClass(int id, string name) : base(id, name)
            {
            }

            public int[] GetData(BlockStateId param)
            {
                return new int[] {param.Id + param.Data << 12};
            }
        }
    }
}
