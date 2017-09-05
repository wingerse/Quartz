using System.Collections.Generic;
using System.Linq;

namespace Quartz.Block
{
    public sealed class BlockId
    {
        public byte NumericId { get; }
        public string Name { get; }

        private BlockId(byte numericId, string name)
        {
            NumericId = numericId;
            Name = name;
        }

        public static readonly BlockId Air = new BlockId(0, "air");
        public static readonly BlockId Stone = new BlockId(1, "stone");
        public static readonly BlockId Grass = new BlockId(2, "grass");
        public static readonly BlockId Dirt = new BlockId(3, "dirt");
        public static readonly BlockId Cobblestone = new BlockId(4, "cobblestone");
        public static readonly BlockId Planks = new BlockId(5, "planks");
        public static readonly BlockId Sapling = new BlockId(6, "sapling");
        public static readonly BlockId Bedrock = new BlockId(7, "bedrock");
        public static readonly BlockId FlowingWater = new BlockId(8, "flowing_water");
        public static readonly BlockId Water = new BlockId(9, "water");
        public static readonly BlockId FlowingLava = new BlockId(10, "flowing_lava");
        public static readonly BlockId Lava = new BlockId(11, "lava");
        public static readonly BlockId Sand = new BlockId(12, "sand");
        public static readonly BlockId Gravel = new BlockId(13, "gravel");
        public static readonly BlockId GoldOre = new BlockId(14, "gold_ore");
        public static readonly BlockId IronOre = new BlockId(15, "iron_ore");
        public static readonly BlockId CoalOre = new BlockId(16, "coal_ore");
        public static readonly BlockId Wood = new BlockId(17, "log");
        public static readonly BlockId Leaves = new BlockId(18, "leaves");
        public static readonly BlockId Sponge = new BlockId(19, "sponge");
        public static readonly BlockId Glass = new BlockId(20, "glass");
        public static readonly BlockId LapisOre = new BlockId(21, "lapis_ore");
        public static readonly BlockId LapisBlock = new BlockId(22, "lapis_block");
        public static readonly BlockId Dispenser = new BlockId(23, "dispenser");
        public static readonly BlockId Sandstone = new BlockId(24, "sandstone");
        public static readonly BlockId NoteBlock = new BlockId(25, "noteblock");
        public static readonly BlockId Bed = new BlockId(26, "bed");
        public static readonly BlockId PoweredRail = new BlockId(27, "golden_rail");
        public static readonly BlockId DetectorRail = new BlockId(28, "detector_rail");
        public static readonly BlockId StickyPiston = new BlockId(29, "sticky_piston");
        public static readonly BlockId Cobweb = new BlockId(30, "web");
        public static readonly BlockId TallGrass = new BlockId(31, "tallgrass");
        public static readonly BlockId DeadBush = new BlockId(32, "deadbush");
        public static readonly BlockId Piston = new BlockId(33, "piston");
        public static readonly BlockId PistonHead = new BlockId(34, "piston_head");
        public static readonly BlockId Wool = new BlockId(35, "wool");
        public static readonly BlockId PistonExtension = new BlockId(36, "piston_extension");
        public static readonly BlockId YellowFlower = new BlockId(37, "yellow_flower");
        public static readonly BlockId RedFlower = new BlockId(38, "red_flower");
        public static readonly BlockId BrownMushroom = new BlockId(39, "brown_mushroom");
        public static readonly BlockId RedMushroom = new BlockId(40, "red_mushroom");
        public static readonly BlockId GoldBlock = new BlockId(41, "gold_block");
        public static readonly BlockId IronBlock = new BlockId(42, "iron_block");
        public static readonly BlockId DoubleStoneSlab = new BlockId(43, "double_stone_slab");
        public static readonly BlockId StoneSlab = new BlockId(44, "stone_slab");
        public static readonly BlockId Bricks = new BlockId(45, "brick_block");
        public static readonly BlockId Tnt = new BlockId(46, "tnt");
        public static readonly BlockId Bookshelf = new BlockId(47, "bookshelf");
        public static readonly BlockId MossStone = new BlockId(48, "mossy_cobblestone");
        public static readonly BlockId Obsidian = new BlockId(49, "obsidian");
        public static readonly BlockId Torch = new BlockId(50, "torch");
        public static readonly BlockId Fire = new BlockId(51, "fire");
        public static readonly BlockId MonsterSpawner = new BlockId(52, "mob_spawner");
        public static readonly BlockId OakWoodStairs = new BlockId(53, "oak_stairs");
        public static readonly BlockId Chest = new BlockId(54, "chest");
        public static readonly BlockId RedstoneDust = new BlockId(55, "redstone_wire");
        public static readonly BlockId DiamondOre = new BlockId(56, "diamond_ore");
        public static readonly BlockId DiamondBlock = new BlockId(57, "diamond_block");
        public static readonly BlockId CraftingTable = new BlockId(58, "crafting_table");
        public static readonly BlockId Crops = new BlockId(59, "wheat");
        public static readonly BlockId Farmland = new BlockId(60, "farmland");
        public static readonly BlockId Furnace = new BlockId(61, "furnace");
        public static readonly BlockId LitFurnance = new BlockId(62, "lit_furnace");
        public static readonly BlockId StandingSign = new BlockId(63, "standing_sign");
        public static readonly BlockId WoodenDoor = new BlockId(64, "wooden_door");
        public static readonly BlockId Ladder = new BlockId(65, "ladder");
        public static readonly BlockId Rail = new BlockId(66, "rail");
        public static readonly BlockId CobblestoneStairs = new BlockId(67, "stone_stairs");
        public static readonly BlockId Sign = new BlockId(68, "wall_sign");
        public static readonly BlockId Lever = new BlockId(69, "lever");
        public static readonly BlockId StonePressurePlate = new BlockId(70, "stone_pressure_plate");
        public static readonly BlockId IronDoor = new BlockId(71, "iron_door");
        public static readonly BlockId WoodenPressurePlate = new BlockId(72, "wooden_pressure_plate");
        public static readonly BlockId RedstoneOre = new BlockId(73, "redstone_ore");
        public static readonly BlockId LitRedstoneOre = new BlockId(74, "lit_redstone_ore");
        public static readonly BlockId UnlitRedstoneTorch = new BlockId(75, "unlit_redstone_torch");
        public static readonly BlockId RedstoneTorch = new BlockId(76, "redstone_torch");
        public static readonly BlockId StoneButton = new BlockId(77, "stone_button");
        public static readonly BlockId SnowLayer = new BlockId(78, "snow_layer");
        public static readonly BlockId Ice = new BlockId(79, "ice");
        public static readonly BlockId Snow = new BlockId(80, "snow");
        public static readonly BlockId Cactus = new BlockId(81, "cactus");
        public static readonly BlockId Clay = new BlockId(82, "clay");
        public static readonly BlockId SugarCane = new BlockId(83, "reeds");
        public static readonly BlockId Jukebox = new BlockId(84, "jukebox");
        public static readonly BlockId OakFence = new BlockId(85, "fence");
        public static readonly BlockId Pumpkin = new BlockId(86, "pumpkin");
        public static readonly BlockId Netherrack = new BlockId(87, "netherrack");
        public static readonly BlockId SoulSand = new BlockId(88, "soul_sand");
        public static readonly BlockId Glowstone = new BlockId(89, "glowstone");
        public static readonly BlockId Portal = new BlockId(90, "portal");
        public static readonly BlockId JackOLantern = new BlockId(91, "lit_pumpkin");
        public static readonly BlockId Cake = new BlockId(92, "cake");
        public static readonly BlockId UnpoweredRepeater = new BlockId(93, "unpowered_repeater");
        public static readonly BlockId PoweredRepeater = new BlockId(94, "powered_repeater");
        public static readonly BlockId StainedGlass = new BlockId(95, "stained_glass");
        public static readonly BlockId WoodenTrapdoor = new BlockId(96, "trapdoor");
        public static readonly BlockId StoneMonsterEgg = new BlockId(97, "monster_egg");
        public static readonly BlockId StoneBricks = new BlockId(98, "stonebrick");
        public static readonly BlockId BrownMushroomBlock = new BlockId(99, "brown_mushroom_block");
        public static readonly BlockId RedMushroomBlock = new BlockId(100, "red_mushroom_block");
        public static readonly BlockId IronBars = new BlockId(101, "iron_bars");
        public static readonly BlockId GlassPane = new BlockId(102, "glass_pane");
        public static readonly BlockId Melon = new BlockId(103, "melon_block");
        public static readonly BlockId PumpkinStem = new BlockId(104, "pumpkin_stem");
        public static readonly BlockId MelonStem = new BlockId(105, "melon_stem");
        public static readonly BlockId Vines = new BlockId(106, "vine");
        public static readonly BlockId OakFenceGate = new BlockId(107, "fence_gate");
        public static readonly BlockId BrickStairs = new BlockId(108, "brick_stairs");
        public static readonly BlockId StoneBrickStairs = new BlockId(109, "stone_brick_stairs");
        public static readonly BlockId Mycelium = new BlockId(110, "mycelium");
        public static readonly BlockId LilyPad = new BlockId(111, "waterlily");
        public static readonly BlockId NetherBrick = new BlockId(112, "nether_brick");
        public static readonly BlockId NetherBrickFence = new BlockId(113, "nether_brick_fence");
        public static readonly BlockId NetherBrickStairs = new BlockId(114, "nether_brick_stairs");
        public static readonly BlockId NetherWart = new BlockId(115, "nether_wart");
        public static readonly BlockId EnchantmentTable = new BlockId(116, "enchanting_table");
        public static readonly BlockId BrewingStand = new BlockId(117, "brewing_stand");
        public static readonly BlockId Cauldron = new BlockId(118, "cauldron");
        public static readonly BlockId EndPortal = new BlockId(119, "end_portal");
        public static readonly BlockId EndPortalFrame = new BlockId(120, "end_portal_frame");
        public static readonly BlockId EndStone = new BlockId(121, "end_stone");
        public static readonly BlockId DragonEgg = new BlockId(122, "dragon_egg");
        public static readonly BlockId RedstoneLamp = new BlockId(123, "redstone_lamp");
        public static readonly BlockId LitRedstoneLamp = new BlockId(124, "lit_redstone_lamp");
        public static readonly BlockId DoubleWoodSlab = new BlockId(125, "double_wooden_slab");
        public static readonly BlockId WoodSlab = new BlockId(126, "wooden_slab");
        public static readonly BlockId Cocoa = new BlockId(127, "cocoa");
        public static readonly BlockId SandstoneStairs = new BlockId(128, "sandstone_stairs");
        public static readonly BlockId EmeraldOre = new BlockId(129, "emerald_ore");
        public static readonly BlockId EnderChest = new BlockId(130, "ender_chest");
        public static readonly BlockId TripwireHook = new BlockId(131, "tripwire_hook");
        public static readonly BlockId Tripwire = new BlockId(132, "tripwire");
        public static readonly BlockId EmeraldBlock = new BlockId(133, "emerald_block");
        public static readonly BlockId SpruceWoodStairs = new BlockId(134, "spruce_stairs");
        public static readonly BlockId BirchWoodStairs = new BlockId(135, "birch_stairs");
        public static readonly BlockId JungleWoodStairs = new BlockId(136, "jungle_stairs");
        public static readonly BlockId CommandBlock = new BlockId(137, "command_block");
        public static readonly BlockId Beacon = new BlockId(138, "beacon");
        public static readonly BlockId CobbleWall = new BlockId(139, "cobblestone_wall");
        public static readonly BlockId FlowerPot = new BlockId(140, "flower_pot");
        public static readonly BlockId Carrots = new BlockId(141, "carrots");
        public static readonly BlockId Potatoes = new BlockId(142, "potatoes");
        public static readonly BlockId Button = new BlockId(143, "wooden_button");
        public static readonly BlockId Skull = new BlockId(144, "skull");
        public static readonly BlockId Anvil = new BlockId(145, "anvil");
        public static readonly BlockId TrappedChest = new BlockId(146, "trapped_chest");
        public static readonly BlockId WeightedPressurePlateLight = new BlockId(147, "light_weighted_pressure_plate");
        public static readonly BlockId WeightedPressurePlateHeavy = new BlockId(148, "heavy_weighted_pressure_plate");
        public static readonly BlockId UnpoweredComparator = new BlockId(149, "unpowered_comparator");
        public static readonly BlockId PoweredComparator = new BlockId(150, "powered_comparator");
        public static readonly BlockId DaylightDetector = new BlockId(151, "daylight_detector");
        public static readonly BlockId RedstoneBlock = new BlockId(152, "redstone_block");
        public static readonly BlockId QuartzOre = new BlockId(153, "quartz_ore");
        public static readonly BlockId Hopper = new BlockId(154, "hopper");
        public static readonly BlockId QuartzBlock = new BlockId(155, "quartz_block");
        public static readonly BlockId QuartzStairs = new BlockId(156, "quartz_stairs");
        public static readonly BlockId ActivatorRail = new BlockId(157, "activator_rail");
        public static readonly BlockId Dropper = new BlockId(158, "dropper");
        public static readonly BlockId StainedTerracotta = new BlockId(159, "stained_hardened_clay");
        public static readonly BlockId StainedGlassPane = new BlockId(160, "stained_glass_pane");
        public static readonly BlockId Leaves2 = new BlockId(161, "leaves2");
        public static readonly BlockId Wood2 = new BlockId(162, "log2");
        public static readonly BlockId AcaciaWoodStairs = new BlockId(163, "acacia_stairs");
        public static readonly BlockId DarkOakWoodStairs = new BlockId(164, "dark_oak_stairs");
        public static readonly BlockId SlimeBlock = new BlockId(165, "slime");
        public static readonly BlockId Barrier = new BlockId(166, "barrier");
        public static readonly BlockId IronTrapdoor = new BlockId(167, "iron_trapdoor");
        public static readonly BlockId Prismarine = new BlockId(168, "prismarine");
        public static readonly BlockId SeaLantern = new BlockId(169, "sea_lantern");
        public static readonly BlockId HayBale = new BlockId(170, "hay_block");
        public static readonly BlockId Carpet = new BlockId(171, "carpet");
        public static readonly BlockId Terracotta = new BlockId(172, "hardened_clay");
        public static readonly BlockId CoalBlock = new BlockId(173, "coal_block");
        public static readonly BlockId PackedIce = new BlockId(174, "packed_ice");
        public static readonly BlockId DoublePlant = new BlockId(175, "double_plant");
        public static readonly BlockId StandingBanner = new BlockId(176, "standing_banner");
        public static readonly BlockId WallBanner = new BlockId(177, "wall_banner");
        public static readonly BlockId DaylightDetectorInverted = new BlockId(178, "daylight_detector_inverted");
        public static readonly BlockId RedSandstone = new BlockId(179, "red_sandstone");
        public static readonly BlockId RedSandstoneStairs = new BlockId(180, "red_sandstone_stairs");
        public static readonly BlockId DoubleStoneSlab2 = new BlockId(181, "double_stone_slab2");
        public static readonly BlockId StoneSlab2 = new BlockId(182, "stone_slab2");
        public static readonly BlockId SpruceFenceGate = new BlockId(183, "spruce_fence_gate");
        public static readonly BlockId BirchFenceGate = new BlockId(184, "birch_fence_gate");
        public static readonly BlockId JungleFenceGate = new BlockId(185, "jungle_fence_gate");
        public static readonly BlockId DarkOakFenceGate = new BlockId(186, "dark_oak_fence_gate");
        public static readonly BlockId AcaciaFenceGate = new BlockId(187, "acacia_fence_gate");
        public static readonly BlockId SpruceFence = new BlockId(188, "spruce_fence");
        public static readonly BlockId BirchFence = new BlockId(189, "birch_fence");
        public static readonly BlockId JungleFence = new BlockId(190, "jungle_fence");
        public static readonly BlockId DarkOakFence = new BlockId(191, "dark_oak_fence");
        public static readonly BlockId AcaciaFence = new BlockId(192, "acacia_fence");
        public static readonly BlockId SpruceDoor = new BlockId(193, "spruce_door");
        public static readonly BlockId BirchDoor = new BlockId(194, "birch_door");
        public static readonly BlockId JungleDoor = new BlockId(195, "jungle_door");
        public static readonly BlockId AcaciaDoor = new BlockId(196, "acacia_door");
        public static readonly BlockId DarkOakDoor = new BlockId(197, "dark_oak_door");
        public static readonly BlockId EndRod = new BlockId(198, "end_rod");
        public static readonly BlockId ChorusPlant = new BlockId(199, "chorus_plant");
        public static readonly BlockId ChorusFlower = new BlockId(200, "chorus_flower");
        public static readonly BlockId PurpurBlock = new BlockId(201, "purpur_block");
        public static readonly BlockId PurpurPillar = new BlockId(202, "purpur_pillar");
        public static readonly BlockId PurpurStairs = new BlockId(203, "purpur_stairs");
        public static readonly BlockId DoublePurpurSlab = new BlockId(204, "purpur_double_slab");
        public static readonly BlockId PurpurSlab = new BlockId(205, "purpur_slab");
        public static readonly BlockId EndStoneBricks = new BlockId(206, "end_bricks");
        public static readonly BlockId Beetroots = new BlockId(207, "beetroots");
        public static readonly BlockId GrassPath = new BlockId(208, "grass_path");
        public static readonly BlockId EndGateway = new BlockId(209, "end_gateway");
        public static readonly BlockId RepeatingCommandBlock = new BlockId(210, "repeating_command_block");
        public static readonly BlockId ChainCommandBlock = new BlockId(211, "chain_command_block");
        public static readonly BlockId FrostedIce = new BlockId(212, "frosted_ice");
        public static readonly BlockId MagmaBlock = new BlockId(213, "magma");
        public static readonly BlockId NetherWartBlock = new BlockId(214, "nether_wart_block");
        public static readonly BlockId RedNetherBrick = new BlockId(215, "red_nether_brick");
        public static readonly BlockId BoneBlock = new BlockId(216, "bone_block");
        public static readonly BlockId StructureVoid = new BlockId(217, "structure_void");
        public static readonly BlockId Observer = new BlockId(218, "observer");
        public static readonly BlockId WhiteShulkerBox = new BlockId(219, "white_shulker_box");
        public static readonly BlockId OrangeShulkerBox = new BlockId(220, "orange_shulker_box");
        public static readonly BlockId MagentaShulkerBox = new BlockId(221, "magenta_shulker_box");
        public static readonly BlockId LightBlueShulkerBox = new BlockId(222, "light_blue_shulker_box");
        public static readonly BlockId YellowShulkerBox = new BlockId(223, "yellow_shulker_box");
        public static readonly BlockId LimeShulkerBox = new BlockId(224, "lime_shulker_box");
        public static readonly BlockId PinkShulkerBox = new BlockId(225, "pink_shulker_box");
        public static readonly BlockId GrayShulkerBox = new BlockId(226, "gray_shulker_box");
        public static readonly BlockId LightGrayShulkerBox = new BlockId(227, "silver_shulker_box");
        public static readonly BlockId CyanShulkerBox = new BlockId(228, "cyan_shulker_box");
        public static readonly BlockId PurpleShulkerBox = new BlockId(229, "purple_shulker_box");
        public static readonly BlockId BlueShulkerBox = new BlockId(230, "blue_shulker_box");
        public static readonly BlockId BrownShulkerBox = new BlockId(231, "brown_shulker_box");
        public static readonly BlockId GreenShulkerBox = new BlockId(232, "green_shulker_box");
        public static readonly BlockId RedShulkerBox = new BlockId(233, "red_shulker_box");
        public static readonly BlockId BlackShulkerBox = new BlockId(234, "black_shulker_box");
        public static readonly BlockId WhiteGlazedTerracotta = new BlockId(235, "white_glazed_terracotta");
        public static readonly BlockId OrangeGlazedTerracotta = new BlockId(236, "orange_glazed_terracotta");
        public static readonly BlockId MagentaGlazedTerracotta = new BlockId(237, "magenta_glazed_terracotta");
        public static readonly BlockId LightBlueGlazedTerracotta = new BlockId(238, "light_blue_glazed_terracotta");
        public static readonly BlockId YellowGlazedTerracotta = new BlockId(239, "yellow_glazed_terracotta");
        public static readonly BlockId LimeGlazedTerracotta = new BlockId(240, "lime_glazed_terracotta");
        public static readonly BlockId PingGlazedTerracotta = new BlockId(241, "pink_glazed_terracotta");
        public static readonly BlockId GrayGlazedTerracotta = new BlockId(242, "gray_glazed_terracotta");
        public static readonly BlockId SilverGlazedTerracotta = new BlockId(243, "silver_glazed_terracotta");
        public static readonly BlockId CyanGlazedTerracotta = new BlockId(244, "cyan_glazed_terracotta");
        public static readonly BlockId PurpleGlazedTerracotta = new BlockId(245, "purple_glazed_terracotta");
        public static readonly BlockId BlueGlazedTerracotta = new BlockId(246, "blue_glazed_terracotta");
        public static readonly BlockId BrownGlazedTerracotta = new BlockId(247, "brown_glazed_terracotta");
        public static readonly BlockId GreenGlazedTerracotta = new BlockId(248, "green_glazed_terracotta");
        public static readonly BlockId RedGlazedTerracotta = new BlockId(249, "red_glazed_terracotta");
        public static readonly BlockId BlackGlazedTerracotta = new BlockId(250, "black_glazed_terracotta");
        public static readonly BlockId Concrete = new BlockId(251, "concrete");
        public static readonly BlockId ConcretePowder = new BlockId(252, "concrete_powder");
        public static readonly BlockId StructureBlock = new BlockId(255, "structure_block");

        private static readonly BlockId[] Values =
        {
            Air, Stone, Grass, Dirt, Cobblestone, Planks, Sapling, Bedrock, FlowingWater, Water, FlowingLava, Lava, Sand, Gravel, GoldOre, IronOre, CoalOre,
            Wood, Leaves, Sponge, Glass, LapisOre, LapisBlock, Dispenser, Sandstone, NoteBlock, Bed, PoweredRail, DetectorRail, StickyPiston, Cobweb, TallGrass,
            DeadBush, Piston, PistonHead, Wool, PistonExtension, YellowFlower, RedFlower, BrownMushroom, RedMushroom, GoldBlock, IronBlock, DoubleStoneSlab,
            StoneSlab, Bricks, Tnt, Bookshelf, MossStone, Obsidian, Torch, Fire, MonsterSpawner, OakWoodStairs, Chest, RedstoneDust, DiamondOre, DiamondBlock,
            CraftingTable, Crops, Farmland, Furnace, LitFurnance, StandingSign, WoodenDoor, Ladder, Rail, CobblestoneStairs, Sign, Lever, StonePressurePlate,
            IronDoor, WoodenPressurePlate, RedstoneOre, LitRedstoneOre, UnlitRedstoneTorch, RedstoneTorch, StoneButton, SnowLayer, Ice, Snow, Cactus, Clay,
            SugarCane, Jukebox, OakFence, Pumpkin, Netherrack, SoulSand, Glowstone, Portal, JackOLantern, Cake, UnpoweredRepeater, PoweredRepeater,
            StainedGlass, WoodenTrapdoor, StoneMonsterEgg, StoneBricks, BrownMushroomBlock, RedMushroomBlock, IronBars, GlassPane, Melon, PumpkinStem,
            MelonStem, Vines, OakFenceGate, BrickStairs, StoneBrickStairs, Mycelium, LilyPad, NetherBrick, NetherBrickFence, NetherBrickStairs, NetherWart,
            EnchantmentTable, BrewingStand, Cauldron, EndPortal, EndPortalFrame, EndStone, DragonEgg, RedstoneLamp, LitRedstoneLamp, DoubleWoodSlab, WoodSlab,
            Cocoa, SandstoneStairs, EmeraldOre, EnderChest, TripwireHook, Tripwire, EmeraldBlock, SpruceWoodStairs, BirchWoodStairs, JungleWoodStairs,
            CommandBlock, Beacon, CobbleWall, FlowerPot, Carrots, Potatoes, Button, Skull, Anvil, TrappedChest, WeightedPressurePlateLight,
            WeightedPressurePlateHeavy, UnpoweredComparator, PoweredComparator, DaylightDetector, RedstoneBlock, QuartzOre, Hopper, QuartzBlock, QuartzStairs,
            ActivatorRail, Dropper, StainedTerracotta, StainedGlassPane, Leaves2, Wood2, AcaciaWoodStairs, DarkOakWoodStairs, SlimeBlock, Barrier, IronTrapdoor,
            Prismarine, SeaLantern, HayBale, Carpet, Terracotta, CoalBlock, PackedIce, DoublePlant, StandingBanner, WallBanner, DaylightDetectorInverted,
            RedSandstone, RedSandstoneStairs, DoubleStoneSlab2, StoneSlab2, SpruceFenceGate, BirchFenceGate, JungleFenceGate, DarkOakFenceGate, AcaciaFenceGate,
            SpruceFence, BirchFence, JungleFence, DarkOakFence, AcaciaFence, SpruceDoor, BirchDoor, JungleDoor, AcaciaDoor, DarkOakDoor, EndRod, ChorusPlant,
            ChorusFlower, PurpurBlock, PurpurPillar, PurpurStairs, DoublePurpurSlab, PurpurSlab, EndStoneBricks, Beetroots, GrassPath, EndGateway,
            RepeatingCommandBlock, ChainCommandBlock, FrostedIce, MagmaBlock, NetherWartBlock, RedNetherBrick, BoneBlock, StructureVoid, Observer,
            WhiteShulkerBox, OrangeShulkerBox, MagentaShulkerBox, LightBlueShulkerBox, YellowShulkerBox, LimeShulkerBox, PinkShulkerBox, GrayShulkerBox,
            LightGrayShulkerBox, CyanShulkerBox, PurpleShulkerBox, BlueShulkerBox, BrownShulkerBox, GreenShulkerBox, RedShulkerBox, BlackShulkerBox,
            WhiteGlazedTerracotta, OrangeGlazedTerracotta, MagentaGlazedTerracotta, LightBlueGlazedTerracotta, YellowGlazedTerracotta, LimeGlazedTerracotta,
            PingGlazedTerracotta, GrayGlazedTerracotta, SilverGlazedTerracotta, CyanGlazedTerracotta, PurpleGlazedTerracotta, BlueGlazedTerracotta,
            BrownGlazedTerracotta, GreenGlazedTerracotta, RedGlazedTerracotta, BlackGlazedTerracotta, Concrete, ConcretePowder, StructureBlock
        };

        private static readonly Dictionary<byte, BlockId> ByNumericId;
        private static readonly Dictionary<string, BlockId> ByName;

        static BlockId()
        {
            ByNumericId = Values.ToDictionary(e => e.NumericId);
            ByName = Values.ToDictionary(e => e.Name);
        }

        /// <summary>
        /// Gets the BlockId based on its numeric ID. Returns it, or null if there is no BlockId with given id.
        /// </summary>
        public static BlockId GetByNumericId(byte id) => ByNumericId.TryGetValue(id, out BlockId blockId) ? blockId : null;

        /// <summary>
        /// Gets the BlockId based on its name. Returns it, or null if there is no BlockId with given name.
        /// </summary>
        public static BlockId GetByName(string name) => ByName.TryGetValue(name, out BlockId blockId) ? blockId : null;
    }
}
