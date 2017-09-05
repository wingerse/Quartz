using System.Collections.Generic;
using System.Linq;

namespace Quartz.Item
{
    public sealed class ItemId
    {
        public ushort NumericId { get; }
        public string Name { get; }

        private ItemId(ushort numericId, string name)
        {
            NumericId = numericId;
            Name = name;
        }

        public static readonly ItemId IronShovel = new ItemId(256, "iron_shovel");
        public static readonly ItemId IronPickaxe = new ItemId(257, "iron_pickaxe");
        public static readonly ItemId IronAxe = new ItemId(258, "iron_axe");
        public static readonly ItemId FlintandSteel = new ItemId(259, "flint_and_steel");
        public static readonly ItemId Apple = new ItemId(260, "apple");
        public static readonly ItemId Bow = new ItemId(261, "bow");
        public static readonly ItemId Arrow = new ItemId(262, "arrow");
        public static readonly ItemId Coal = new ItemId(263, "coal");
        public static readonly ItemId Diamond = new ItemId(264, "diamond");
        public static readonly ItemId IronIngot = new ItemId(265, "iron_ingot");
        public static readonly ItemId GoldIngot = new ItemId(266, "gold_ingot");
        public static readonly ItemId IronSword = new ItemId(267, "iron_sword");
        public static readonly ItemId WoodenSword = new ItemId(268, "wooden_sword");
        public static readonly ItemId WoodenShovel = new ItemId(269, "wooden_shovel");
        public static readonly ItemId WoodenPickaxe = new ItemId(270, "wooden_pickaxe");
        public static readonly ItemId WoodenAxe = new ItemId(271, "wooden_axe");
        public static readonly ItemId StoneSword = new ItemId(272, "stone_sword");
        public static readonly ItemId StoneShovel = new ItemId(273, "stone_shovel");
        public static readonly ItemId StonePickaxe = new ItemId(274, "stone_pickaxe");
        public static readonly ItemId StoneAxe = new ItemId(275, "stone_axe");
        public static readonly ItemId DiamondSword = new ItemId(276, "diamond_sword");
        public static readonly ItemId DiamondShovel = new ItemId(277, "diamond_shovel");
        public static readonly ItemId DiamondPickaxe = new ItemId(278, "diamond_pickaxe");
        public static readonly ItemId DiamondAxe = new ItemId(279, "diamond_axe");
        public static readonly ItemId Stick = new ItemId(280, "stick");
        public static readonly ItemId Bowl = new ItemId(281, "bowl");
        public static readonly ItemId MushroomStew = new ItemId(282, "mushroom_stew");
        public static readonly ItemId GoldenSword = new ItemId(283, "golden_sword");
        public static readonly ItemId GoldenShovel = new ItemId(284, "golden_shovel");
        public static readonly ItemId GoldenPickaxe = new ItemId(285, "golden_pickaxe");
        public static readonly ItemId GoldenAxe = new ItemId(286, "golden_axe");
        public static readonly ItemId String = new ItemId(287, "string");
        public static readonly ItemId Feather = new ItemId(288, "feather");
        public static readonly ItemId Gunpowder = new ItemId(289, "gunpowder");
        public static readonly ItemId WoodenHoe = new ItemId(290, "wooden_hoe");
        public static readonly ItemId StoneHoe = new ItemId(291, "stone_hoe");
        public static readonly ItemId IronHoe = new ItemId(292, "iron_hoe");
        public static readonly ItemId DiamondHoe = new ItemId(293, "diamond_hoe");
        public static readonly ItemId GoldenHoe = new ItemId(294, "golden_hoe");
        public static readonly ItemId Seeds = new ItemId(295, "wheat_seeds");
        public static readonly ItemId Wheat = new ItemId(296, "wheat");
        public static readonly ItemId Bread = new ItemId(297, "bread");
        public static readonly ItemId LeatherCap = new ItemId(298, "leather_helmet");
        public static readonly ItemId LeatherTunic = new ItemId(299, "leather_chestplate");
        public static readonly ItemId LeatherPants = new ItemId(300, "leather_leggings");
        public static readonly ItemId LeatherBoots = new ItemId(301, "leather_boots");
        public static readonly ItemId ChainHelmet = new ItemId(302, "chainmail_helmet");
        public static readonly ItemId ChainChestplate = new ItemId(303, "chainmail_chestplate");
        public static readonly ItemId ChainLeggings = new ItemId(304, "chainmail_leggings");
        public static readonly ItemId ChainBoots = new ItemId(305, "chainmail_boots");
        public static readonly ItemId IronHelmet = new ItemId(306, "iron_helmet");
        public static readonly ItemId IronChestplate = new ItemId(307, "iron_chestplate");
        public static readonly ItemId IronLeggings = new ItemId(308, "iron_leggings");
        public static readonly ItemId IronBoots = new ItemId(309, "iron_boots");
        public static readonly ItemId DiamondHelmet = new ItemId(310, "diamond_helmet");
        public static readonly ItemId DiamondChestplate = new ItemId(311, "diamond_chestplate");
        public static readonly ItemId DiamondLeggings = new ItemId(312, "diamond_leggings");
        public static readonly ItemId DiamondBoots = new ItemId(313, "diamond_boots");
        public static readonly ItemId GoldenHelmet = new ItemId(314, "golden_helmet");
        public static readonly ItemId GoldenChestplate = new ItemId(315, "golden_chestplate");
        public static readonly ItemId GoldenLeggings = new ItemId(316, "golden_leggings");
        public static readonly ItemId GoldenBoots = new ItemId(317, "golden_boots");
        public static readonly ItemId Flint = new ItemId(318, "flint");
        public static readonly ItemId RawPorkchop = new ItemId(319, "porkchop");
        public static readonly ItemId CookedPorkchop = new ItemId(320, "cooked_porkchop");
        public static readonly ItemId Painting = new ItemId(321, "painting");
        public static readonly ItemId GoldenApple = new ItemId(322, "golden_apple");
        public static readonly ItemId Sign = new ItemId(323, "sign");
        public static readonly ItemId OakDoor = new ItemId(324, "wooden_door");
        public static readonly ItemId Bucket = new ItemId(325, "bucket");
        public static readonly ItemId WaterBucket = new ItemId(326, "water_bucket");
        public static readonly ItemId LavaBucket = new ItemId(327, "lava_bucket");
        public static readonly ItemId Minecart = new ItemId(328, "minecart");
        public static readonly ItemId Saddle = new ItemId(329, "saddle");
        public static readonly ItemId IronDoor = new ItemId(330, "iron_door");
        public static readonly ItemId Redstone = new ItemId(331, "redstone");
        public static readonly ItemId Snowball = new ItemId(332, "snowball");
        public static readonly ItemId Boat = new ItemId(333, "boat");
        public static readonly ItemId Leather = new ItemId(334, "leather");
        public static readonly ItemId Milk = new ItemId(335, "milk_bucket");
        public static readonly ItemId Brick = new ItemId(336, "brick");
        public static readonly ItemId Clay = new ItemId(337, "clay_ball");
        public static readonly ItemId SugarCanes = new ItemId(338, "reeds");
        public static readonly ItemId Paper = new ItemId(339, "paper");
        public static readonly ItemId Book = new ItemId(340, "book");
        public static readonly ItemId Slimeball = new ItemId(341, "slime_ball");
        public static readonly ItemId ChestMinecart = new ItemId(342, "chest_minecart");
        public static readonly ItemId FurnaceMinecart = new ItemId(343, "furnace_minecart");
        public static readonly ItemId Egg = new ItemId(344, "egg");
        public static readonly ItemId Compass = new ItemId(345, "compass");
        public static readonly ItemId FishingRod = new ItemId(346, "fishing_rod");
        public static readonly ItemId Clock = new ItemId(347, "clock");
        public static readonly ItemId GlowstoneDust = new ItemId(348, "glowstone_dust");
        public static readonly ItemId Fish = new ItemId(349, "fish");
        public static readonly ItemId CoodkedFish = new ItemId(350, "cooked_fish");
        public static readonly ItemId DyePowder = new ItemId(351, "dye");
        public static readonly ItemId Bone = new ItemId(352, "bone");
        public static readonly ItemId Sugar = new ItemId(353, "sugar");
        public static readonly ItemId Cake = new ItemId(354, "cake");
        public static readonly ItemId Bed = new ItemId(355, "bed");
        public static readonly ItemId RedstoneRepeater = new ItemId(356, "repeater");
        public static readonly ItemId Cookie = new ItemId(357, "cookie");
        public static readonly ItemId Map = new ItemId(358, "filled_map");
        public static readonly ItemId Shears = new ItemId(359, "shears");
        public static readonly ItemId Melon = new ItemId(360, "melon");
        public static readonly ItemId PumpkinSeeds = new ItemId(361, "pumpkin_seeds");
        public static readonly ItemId MelonSeeds = new ItemId(362, "melon_seeds");
        public static readonly ItemId RawBeef = new ItemId(363, "beef");
        public static readonly ItemId Steak = new ItemId(364, "cooked_beef");
        public static readonly ItemId RawChicken = new ItemId(365, "chicken");
        public static readonly ItemId CookedChicken = new ItemId(366, "cooked_chicken");
        public static readonly ItemId RottenFlesh = new ItemId(367, "rotten_flesh");
        public static readonly ItemId EnderPearl = new ItemId(368, "ender_pearl");
        public static readonly ItemId BlazeRod = new ItemId(369, "blaze_rod");
        public static readonly ItemId GhastTear = new ItemId(370, "ghast_tear");
        public static readonly ItemId GoldNugget = new ItemId(371, "gold_nugget");
        public static readonly ItemId NetherWart = new ItemId(372, "nether_wart");
        public static readonly ItemId Potion = new ItemId(373, "potion");
        public static readonly ItemId GlassBottle = new ItemId(374, "glass_bottle");
        public static readonly ItemId SpiderEye = new ItemId(375, "spider_eye");
        public static readonly ItemId FermentedSpiderEye = new ItemId(376, "fermented_spider_eye");
        public static readonly ItemId BlazePowder = new ItemId(377, "blaze_powder");
        public static readonly ItemId MagmaCream = new ItemId(378, "magma_cream");
        public static readonly ItemId BrewingStand = new ItemId(379, "brewing_stand");
        public static readonly ItemId Cauldron = new ItemId(380, "cauldron");
        public static readonly ItemId EyeOfEnder = new ItemId(381, "ender_eye");
        public static readonly ItemId GlisteringMelon = new ItemId(382, "speckled_melon");
        public static readonly ItemId SpawnEgg = new ItemId(383, "spawn_egg");
        public static readonly ItemId BottleOEnchanting = new ItemId(384, "experience_bottle");
        public static readonly ItemId FireCharge = new ItemId(385, "fire_charge");
        public static readonly ItemId BookAndQuill = new ItemId(386, "writable_book");
        public static readonly ItemId WrittenBook = new ItemId(387, "written_book");
        public static readonly ItemId Emerald = new ItemId(388, "emerald");
        public static readonly ItemId ItemFrame = new ItemId(389, "item_frame");
        public static readonly ItemId FlowerPot = new ItemId(390, "flower_pot");
        public static readonly ItemId Carrot = new ItemId(391, "carrot");
        public static readonly ItemId Potato = new ItemId(392, "potato");
        public static readonly ItemId BakedPotato = new ItemId(393, "baked_potato");
        public static readonly ItemId PoisonousPotato = new ItemId(394, "poisonous_potato");
        public static readonly ItemId EmptyMap = new ItemId(395, "map");
        public static readonly ItemId GoldenCarrot = new ItemId(396, "golden_carrot");
        public static readonly ItemId Skull = new ItemId(397, "skull");
        public static readonly ItemId CarrotOnAStick = new ItemId(398, "carrot_on_a_stick");
        public static readonly ItemId NetherStar = new ItemId(399, "nether_star");
        public static readonly ItemId PumpkinPie = new ItemId(400, "pumpkin_pie");
        public static readonly ItemId FireworkRocket = new ItemId(401, "fireworks");
        public static readonly ItemId FireworkStar = new ItemId(402, "firework_charge");
        public static readonly ItemId EnchantedBook = new ItemId(403, "enchanted_book");
        public static readonly ItemId RedstoneComparator = new ItemId(404, "comparator");
        public static readonly ItemId NetherBrick = new ItemId(405, "netherbrick");
        public static readonly ItemId Quartz = new ItemId(406, "quartz");
        public static readonly ItemId TntMinecart = new ItemId(407, "tnt_minecart");
        public static readonly ItemId HopperMinecart = new ItemId(408, "hopper_minecart");
        public static readonly ItemId PrismarineShard = new ItemId(409, "prismarine_shard");
        public static readonly ItemId PrismarineCrystals = new ItemId(410, "prismarine_crystals");
        public static readonly ItemId RawRabbit = new ItemId(411, "rabbit");
        public static readonly ItemId CookedRabbit = new ItemId(412, "cooked_rabbit");
        public static readonly ItemId RabbitStew = new ItemId(413, "rabbit_stew");
        public static readonly ItemId RabbitFoot = new ItemId(414, "rabbit_foot");
        public static readonly ItemId RabbitHide = new ItemId(415, "rabbit_hide");
        public static readonly ItemId ArmorStand = new ItemId(416, "armor_stand");
        public static readonly ItemId IronHorseArmor = new ItemId(417, "iron_horse_armor");
        public static readonly ItemId GoldHorseArmor = new ItemId(418, "golden_horse_armor");
        public static readonly ItemId DiamondHorseArmor = new ItemId(419, "diamond_horse_armor");
        public static readonly ItemId Lead = new ItemId(420, "lead");
        public static readonly ItemId NameTag = new ItemId(421, "name_tag");
        public static readonly ItemId CommandBlockMinecart = new ItemId(422, "command_block_minecart");
        public static readonly ItemId RawMutton = new ItemId(423, "mutton");
        public static readonly ItemId CookedMutton = new ItemId(424, "cooked_mutton");
        public static readonly ItemId Banner = new ItemId(425, "banner");
        public static readonly ItemId EndCrystal = new ItemId(426, "end_crystal");
        public static readonly ItemId SpruceDoor = new ItemId(427, "spruce_door");
        public static readonly ItemId BirchDoor = new ItemId(428, "birch_door");
        public static readonly ItemId JungleDoor = new ItemId(429, "jungle_door");
        public static readonly ItemId AcaciaDoor = new ItemId(430, "acacia_door");
        public static readonly ItemId DarkOakDoor = new ItemId(431, "dark_oak_door");
        public static readonly ItemId ChorusFruit = new ItemId(432, "chorus_fruit");
        public static readonly ItemId PoppedChorusFruit = new ItemId(433, "chorus_fruit_popped");
        public static readonly ItemId Beetroot = new ItemId(434, "beetroot");
        public static readonly ItemId BeetrootSeeds = new ItemId(435, "beetroot_seeds");
        public static readonly ItemId BeetrootSoup = new ItemId(436, "beetroot_soup");
        public static readonly ItemId DragonBreath = new ItemId(437, "dragon_breath");
        public static readonly ItemId SplashPotion = new ItemId(438, "splash_potion");
        public static readonly ItemId SpectralArrow = new ItemId(439, "spectral_arrow");
        public static readonly ItemId TippedArrow = new ItemId(440, "tipped_arrow");
        public static readonly ItemId LingeringPotion = new ItemId(441, "lingering_potion");
        public static readonly ItemId Shield = new ItemId(442, "shield");
        public static readonly ItemId Elytra = new ItemId(443, "elytra");
        public static readonly ItemId SpruceBoat = new ItemId(444, "spruce_boat");
        public static readonly ItemId BirchBoat = new ItemId(445, "birch_boat");
        public static readonly ItemId JungleBoat = new ItemId(446, "jungle_boat");
        public static readonly ItemId AcaciaBoat = new ItemId(447, "acacia_boat");
        public static readonly ItemId DarkOakBoat = new ItemId(448, "dark_oak_boat");
        public static readonly ItemId TotemOfUndying = new ItemId(449, "totem_of_undying");
        public static readonly ItemId ShulkerShell = new ItemId(450, "shulker_shell");
        public static readonly ItemId IronNugget = new ItemId(452, "iron_nugget");
        public static readonly ItemId KnowledgeBook = new ItemId(453, "knowledge_book");
        public static readonly ItemId Record13 = new ItemId(2256, "record_13");
        public static readonly ItemId RecordCat = new ItemId(2257, "record_cat");
        public static readonly ItemId RecordBlocks = new ItemId(2258, "record_blocks");
        public static readonly ItemId RecordChirp = new ItemId(2259, "record_chirp");
        public static readonly ItemId RecordFar = new ItemId(2260, "record_far");
        public static readonly ItemId RecordMall = new ItemId(2261, "record_mall");
        public static readonly ItemId RecordMellohi = new ItemId(2262, "record_mellohi");
        public static readonly ItemId RecordStal = new ItemId(2263, "record_stal");
        public static readonly ItemId RecordStrad = new ItemId(2264, "record_strad");
        public static readonly ItemId RecordWard = new ItemId(2265, "record_ward");
        public static readonly ItemId Record11 = new ItemId(2266, "record_11");
        public static readonly ItemId RecordWait = new ItemId(2267, "record_wait");

        private static readonly ItemId[] Values =
        {
            IronShovel, IronPickaxe, IronAxe, FlintandSteel, Apple, Bow, Arrow, Coal, Diamond, IronIngot, GoldIngot, IronSword, WoodenSword, WoodenShovel,
            WoodenPickaxe, WoodenAxe, StoneSword, StoneShovel, StonePickaxe, StoneAxe, DiamondSword, DiamondShovel, DiamondPickaxe, DiamondAxe, Stick, Bowl,
            MushroomStew, GoldenSword, GoldenShovel, GoldenPickaxe, GoldenAxe, String, Feather, Gunpowder, WoodenHoe, StoneHoe, IronHoe, DiamondHoe, GoldenHoe,
            Seeds, Wheat, Bread, LeatherCap, LeatherTunic, LeatherPants, LeatherBoots, ChainHelmet, ChainChestplate, ChainLeggings, ChainBoots, IronHelmet,
            IronChestplate, IronLeggings, IronBoots, DiamondHelmet, DiamondChestplate, DiamondLeggings, DiamondBoots, GoldenHelmet, GoldenChestplate,
            GoldenLeggings, GoldenBoots, Flint, RawPorkchop, CookedPorkchop, Painting, GoldenApple, Sign, OakDoor, Bucket, WaterBucket, LavaBucket, Minecart,
            Saddle, IronDoor, Redstone, Snowball, Boat, Leather, Milk, Brick, Clay, SugarCanes, Paper, Book, Slimeball, ChestMinecart, FurnaceMinecart, Egg,
            Compass, FishingRod, Clock, GlowstoneDust, Fish, CoodkedFish, DyePowder, Bone, Sugar, Cake, Bed, RedstoneRepeater, Cookie, Map, Shears, Melon,
            PumpkinSeeds, MelonSeeds, RawBeef, Steak, RawChicken, CookedChicken, RottenFlesh, EnderPearl, BlazeRod, GhastTear, GoldNugget, NetherWart, Potion,
            GlassBottle, SpiderEye, FermentedSpiderEye, BlazePowder, MagmaCream, BrewingStand, Cauldron, EyeOfEnder, GlisteringMelon, SpawnEgg,
            BottleOEnchanting, FireCharge, BookAndQuill, WrittenBook, Emerald, ItemFrame, FlowerPot, Carrot, Potato, BakedPotato, PoisonousPotato, EmptyMap,
            GoldenCarrot, Skull, CarrotOnAStick, NetherStar, PumpkinPie, FireworkRocket, FireworkStar, EnchantedBook, RedstoneComparator, NetherBrick, Quartz,
            TntMinecart, HopperMinecart, PrismarineShard, PrismarineCrystals, RawRabbit, CookedRabbit, RabbitStew, RabbitFoot, RabbitHide, ArmorStand,
            IronHorseArmor, GoldHorseArmor, DiamondHorseArmor, Lead, NameTag, CommandBlockMinecart, RawMutton, CookedMutton, Banner, EndCrystal, SpruceDoor,
            BirchDoor, JungleDoor, AcaciaDoor, DarkOakDoor, ChorusFruit, PoppedChorusFruit, Beetroot, BeetrootSeeds, BeetrootSoup, DragonBreath, SplashPotion,
            SpectralArrow, TippedArrow, LingeringPotion, Shield, Elytra, SpruceBoat, BirchBoat, JungleBoat, AcaciaBoat, DarkOakBoat, TotemOfUndying,
            ShulkerShell, IronNugget, KnowledgeBook, Record13, RecordCat, RecordBlocks, RecordChirp, RecordFar, RecordMall, RecordMellohi, RecordStal,
            RecordStrad, RecordWard, Record11, RecordWait
        };

        private static readonly Dictionary<ushort, ItemId> ByNumericId;
        private static readonly Dictionary<string, ItemId> ByName;

        static ItemId()
        {
            ByNumericId = Values.ToDictionary(e => e.NumericId);
            ByName = Values.ToDictionary(e => e.Name);
        }

        /// <summary>
        /// Gets an ItemId based on it's numeric Id. Returns it, or null if there is no ItemId with given numeric id.
        /// </summary>
        public ItemId GetByNumericId(ushort id) => ByNumericId.TryGetValue(id, out ItemId itemId) ? itemId : null;
        
        /// <summary>
        /// Gets an ItemId based on it's name. Returns it, or null if there is no ItemId with given name.
        /// </summary>
        public ItemId GetByName(string name) => ByName.TryGetValue(name, out ItemId itemId) ? itemId : null;
    }
}
