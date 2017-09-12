using System.Collections.Generic;
using System.Linq;

namespace Quartz.Sound
{
    public sealed class Sound
    {
        public int Id { get; }
        public string Name { get; }

        private Sound(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static readonly Sound AmbientCave = new Sound(0, "ambient.cave");
        public static readonly Sound BlockAnvilBreak = new Sound(1, "block.anvil.break");
        public static readonly Sound BlockAnvilDestroy = new Sound(2, "block.anvil.destroy");
        public static readonly Sound BlockAnvilFall = new Sound(3, "block.anvil.fall");
        public static readonly Sound BlockAnvilHit = new Sound(4, "block.anvil.hit");
        public static readonly Sound BlockAnvilLand = new Sound(5, "block.anvil.land");
        public static readonly Sound BlockAnvilPlace = new Sound(6, "block.anvil.place");
        public static readonly Sound BlockAnvilStep = new Sound(7, "block.anvil.step");
        public static readonly Sound BlockAnvilUse = new Sound(8, "block.anvil.use");
        public static readonly Sound BlockBrewingStandBrew = new Sound(9, "block.brewing_stand.brew");
        public static readonly Sound BlockChestClose = new Sound(10, "block.chest.close");
        public static readonly Sound BlockChestLocked = new Sound(11, "block.chest.locked");
        public static readonly Sound BlockChestOpen = new Sound(12, "block.chest.open");
        public static readonly Sound BlockChorusFlowerDeath = new Sound(13, "block.chorus_flower.death");
        public static readonly Sound BlockChorusFlowerGrow = new Sound(14, "block.chorus_flower.grow");
        public static readonly Sound BlockClothBreak = new Sound(15, "block.cloth.break");
        public static readonly Sound BlockClothFall = new Sound(16, "block.cloth.fall");
        public static readonly Sound BlockClothHit = new Sound(17, "block.cloth.hit");
        public static readonly Sound BlockClothPlace = new Sound(18, "block.cloth.place");
        public static readonly Sound BlockClothStep = new Sound(19, "block.cloth.step");
        public static readonly Sound BlockComparatorClick = new Sound(20, "block.comparator.click");
        public static readonly Sound BlockDispenserDispense = new Sound(21, "block.dispenser.dispense");
        public static readonly Sound BlockDispenserFail = new Sound(22, "block.dispenser.fail");
        public static readonly Sound BlockDispenserLaunch = new Sound(23, "block.dispenser.launch");
        public static readonly Sound BlockEnchantmentTableUse = new Sound(24, "block.enchantment_table.use");
        public static readonly Sound BlockEndGatewaySpawn = new Sound(25, "block.end_gateway.spawn");
        public static readonly Sound BlockEndPortalSpawn = new Sound(26, "block.end_portal.spawn");
        public static readonly Sound BlockEndPortalFrameFill = new Sound(27, "block.end_portal_frame.fill");
        public static readonly Sound BlockEnderchestClose = new Sound(28, "block.enderchest.close");
        public static readonly Sound BlockEnderchestOpen = new Sound(29, "block.enderchest.open");
        public static readonly Sound BlockFenceGateClose = new Sound(30, "block.fence_gate.close");
        public static readonly Sound BlockFenceGateOpen = new Sound(31, "block.fence_gate.open");
        public static readonly Sound BlockFireAmbient = new Sound(32, "block.fire.ambient");
        public static readonly Sound BlockFireExtinguish = new Sound(33, "block.fire.extinguish");
        public static readonly Sound BlockFurnaceFireCrackle = new Sound(34, "block.furnace.fire_crackle");
        public static readonly Sound BlockGlassBreak = new Sound(35, "block.glass.break");
        public static readonly Sound BlockGlassFall = new Sound(36, "block.glass.fall");
        public static readonly Sound BlockGlassHit = new Sound(37, "block.glass.hit");
        public static readonly Sound BlockGlassPlace = new Sound(38, "block.glass.place");
        public static readonly Sound BlockGlassStep = new Sound(39, "block.glass.step");
        public static readonly Sound BlockGrassBreak = new Sound(40, "block.grass.break");
        public static readonly Sound BlockGrassFall = new Sound(41, "block.grass.fall");
        public static readonly Sound BlockGrassHit = new Sound(42, "block.grass.hit");
        public static readonly Sound BlockGrassPlace = new Sound(43, "block.grass.place");
        public static readonly Sound BlockGrassStep = new Sound(44, "block.grass.step");
        public static readonly Sound BlockGravelBreak = new Sound(45, "block.gravel.break");
        public static readonly Sound BlockGravelFall = new Sound(46, "block.gravel.fall");
        public static readonly Sound BlockGravelHit = new Sound(47, "block.gravel.hit");
        public static readonly Sound BlockGravelPlace = new Sound(48, "block.gravel.place");
        public static readonly Sound BlockGravelStep = new Sound(49, "block.gravel.step");
        public static readonly Sound BlockIronDoorClose = new Sound(50, "block.iron_door.close");
        public static readonly Sound BlockIronDoorOpen = new Sound(51, "block.iron_door.open");
        public static readonly Sound BlockIronTrapdoorClose = new Sound(52, "block.iron_trapdoor.close");
        public static readonly Sound BlockIronTrapdoorOpen = new Sound(53, "block.iron_trapdoor.open");
        public static readonly Sound BlockLadderBreak = new Sound(54, "block.ladder.break");
        public static readonly Sound BlockLadderFall = new Sound(55, "block.ladder.fall");
        public static readonly Sound BlockLadderHit = new Sound(56, "block.ladder.hit");
        public static readonly Sound BlockLadderPlace = new Sound(57, "block.ladder.place");
        public static readonly Sound BlockLadderStep = new Sound(58, "block.ladder.step");
        public static readonly Sound BlockLavaAmbient = new Sound(59, "block.lava.ambient");
        public static readonly Sound BlockLavaExtinguish = new Sound(60, "block.lava.extinguish");
        public static readonly Sound BlockLavaPop = new Sound(61, "block.lava.pop");
        public static readonly Sound BlockLeverClick = new Sound(62, "block.lever.click");
        public static readonly Sound BlockMetalBreak = new Sound(63, "block.metal.break");
        public static readonly Sound BlockMetalFall = new Sound(64, "block.metal.fall");
        public static readonly Sound BlockMetalHit = new Sound(65, "block.metal.hit");
        public static readonly Sound BlockMetalPlace = new Sound(66, "block.metal.place");
        public static readonly Sound BlockMetalStep = new Sound(67, "block.metal.step");
        public static readonly Sound BlockMetalPressureplateClickOff = new Sound(68, "block.metal_pressureplate.click_off");
        public static readonly Sound BlockMetalPressureplateClickOn = new Sound(69, "block.metal_pressureplate.click_on");
        public static readonly Sound BlockNoteBasedrum = new Sound(70, "block.note.basedrum");
        public static readonly Sound BlockNoteBass = new Sound(71, "block.note.bass");
        public static readonly Sound BlockNoteBell = new Sound(72, "block.note.bell");
        public static readonly Sound BlockNoteChime = new Sound(73, "block.note.chime");
        public static readonly Sound BlockNoteFlute = new Sound(74, "block.note.flute");
        public static readonly Sound BlockNoteGuitar = new Sound(75, "block.note.guitar");
        public static readonly Sound BlockNoteHarp = new Sound(76, "block.note.harp");
        public static readonly Sound BlockNoteHat = new Sound(77, "block.note.hat");
        public static readonly Sound BlockNotePling = new Sound(78, "block.note.pling");
        public static readonly Sound BlockNoteSnare = new Sound(79, "block.note.snare");
        public static readonly Sound BlockNoteXylophone = new Sound(80, "block.note.xylophone");
        public static readonly Sound BlockPistonContract = new Sound(81, "block.piston.contract");
        public static readonly Sound BlockPistonExtend = new Sound(82, "block.piston.extend");
        public static readonly Sound BlockPortalAmbient = new Sound(83, "block.portal.ambient");
        public static readonly Sound BlockPortalTravel = new Sound(84, "block.portal.travel");
        public static readonly Sound BlockPortalTrigger = new Sound(85, "block.portal.trigger");
        public static readonly Sound BlockRedstoneTorchBurnout = new Sound(86, "block.redstone_torch.burnout");
        public static readonly Sound BlockSandBreak = new Sound(87, "block.sand.break");
        public static readonly Sound BlockSandFall = new Sound(88, "block.sand.fall");
        public static readonly Sound BlockSandHit = new Sound(89, "block.sand.hit");
        public static readonly Sound BlockSandPlace = new Sound(90, "block.sand.place");
        public static readonly Sound BlockSandStep = new Sound(91, "block.sand.step");
        public static readonly Sound BlockShulkerBoxClose = new Sound(92, "block.shulker_box.close");
        public static readonly Sound BlockShulkerBoxOpen = new Sound(93, "block.shulker_box.open");
        public static readonly Sound BlockSlimeBreak = new Sound(94, "block.slime.break");
        public static readonly Sound BlockSlimeFall = new Sound(95, "block.slime.fall");
        public static readonly Sound BlockSlimeHit = new Sound(96, "block.slime.hit");
        public static readonly Sound BlockSlimePlace = new Sound(97, "block.slime.place");
        public static readonly Sound BlockSlimeStep = new Sound(98, "block.slime.step");
        public static readonly Sound BlockSnowBreak = new Sound(99, "block.snow.break");
        public static readonly Sound BlockSnowFall = new Sound(100, "block.snow.fall");
        public static readonly Sound BlockSnowHit = new Sound(101, "block.snow.hit");
        public static readonly Sound BlockSnowPlace = new Sound(102, "block.snow.place");
        public static readonly Sound BlockSnowStep = new Sound(103, "block.snow.step");
        public static readonly Sound BlockStoneBreak = new Sound(104, "block.stone.break");
        public static readonly Sound BlockStoneFall = new Sound(105, "block.stone.fall");
        public static readonly Sound BlockStoneHit = new Sound(106, "block.stone.hit");
        public static readonly Sound BlockStonePlace = new Sound(107, "block.stone.place");
        public static readonly Sound BlockStoneStep = new Sound(108, "block.stone.step");
        public static readonly Sound BlockStoneButtonClickOff = new Sound(109, "block.stone_button.click_off");
        public static readonly Sound BlockStoneButtonClickOn = new Sound(110, "block.stone_button.click_on");
        public static readonly Sound BlockStonePressureplateClickOff = new Sound(111, "block.stone_pressureplate.click_off");
        public static readonly Sound BlockStonePressureplateClickOn = new Sound(112, "block.stone_pressureplate.click_on");
        public static readonly Sound BlockTripwireAttach = new Sound(113, "block.tripwire.attach");
        public static readonly Sound BlockTripwireClickOff = new Sound(114, "block.tripwire.click_off");
        public static readonly Sound BlockTripwireClickOn = new Sound(115, "block.tripwire.click_on");
        public static readonly Sound BlockTripwireDetach = new Sound(116, "block.tripwire.detach");
        public static readonly Sound BlockWaterAmbient = new Sound(117, "block.water.ambient");
        public static readonly Sound BlockWaterlilyPlace = new Sound(118, "block.waterlily.place");
        public static readonly Sound BlockWoodBreak = new Sound(119, "block.wood.break");
        public static readonly Sound BlockWoodFall = new Sound(120, "block.wood.fall");
        public static readonly Sound BlockWoodHit = new Sound(121, "block.wood.hit");
        public static readonly Sound BlockWoodPlace = new Sound(122, "block.wood.place");
        public static readonly Sound BlockWoodStep = new Sound(123, "block.wood.step");
        public static readonly Sound BlockWoodButtonClickOff = new Sound(124, "block.wood_button.click_off");
        public static readonly Sound BlockWoodButtonClickOn = new Sound(125, "block.wood_button.click_on");
        public static readonly Sound BlockWoodPressureplateClickOff = new Sound(126, "block.wood_pressureplate.click_off");
        public static readonly Sound BlockWoodPressureplateClickOn = new Sound(127, "block.wood_pressureplate.click_on");
        public static readonly Sound BlockWoodenDoorClose = new Sound(128, "block.wooden_door.close");
        public static readonly Sound BlockWoodenDoorOpen = new Sound(129, "block.wooden_door.open");
        public static readonly Sound BlockWoodenTrapdoorClose = new Sound(130, "block.wooden_trapdoor.close");
        public static readonly Sound BlockWoodenTrapdoorOpen = new Sound(131, "block.wooden_trapdoor.open");
        public static readonly Sound EnchantThornsHit = new Sound(132, "enchant.thorns.hit");
        public static readonly Sound EntityArmorstandBreak = new Sound(133, "entity.armorstand.break");
        public static readonly Sound EntityArmorstandFall = new Sound(134, "entity.armorstand.fall");
        public static readonly Sound EntityArmorstandHit = new Sound(135, "entity.armorstand.hit");
        public static readonly Sound EntityArmorstandPlace = new Sound(136, "entity.armorstand.place");
        public static readonly Sound EntityArrowHit = new Sound(137, "entity.arrow.hit");
        public static readonly Sound EntityArrowHitPlayer = new Sound(138, "entity.arrow.hit_player");
        public static readonly Sound EntityArrowShoot = new Sound(139, "entity.arrow.shoot");
        public static readonly Sound EntityBatAmbient = new Sound(140, "entity.bat.ambient");
        public static readonly Sound EntityBatDeath = new Sound(141, "entity.bat.death");
        public static readonly Sound EntityBatHurt = new Sound(142, "entity.bat.hurt");
        public static readonly Sound EntityBatLoop = new Sound(143, "entity.bat.loop");
        public static readonly Sound EntityBatTakeoff = new Sound(144, "entity.bat.takeoff");
        public static readonly Sound EntityBlazeAmbient = new Sound(145, "entity.blaze.ambient");
        public static readonly Sound EntityBlazeBurn = new Sound(146, "entity.blaze.burn");
        public static readonly Sound EntityBlazeDeath = new Sound(147, "entity.blaze.death");
        public static readonly Sound EntityBlazeHurt = new Sound(148, "entity.blaze.hurt");
        public static readonly Sound EntityBlazeShoot = new Sound(149, "entity.blaze.shoot");
        public static readonly Sound EntityBoatPaddleLand = new Sound(150, "entity.boat.paddle_land");
        public static readonly Sound EntityBoatPaddleWater = new Sound(151, "entity.boat.paddle_water");
        public static readonly Sound EntityBobberRetrieve = new Sound(152, "entity.bobber.retrieve");
        public static readonly Sound EntityBobberSplash = new Sound(153, "entity.bobber.splash");
        public static readonly Sound EntityBobberThrow = new Sound(154, "entity.bobber.throw");
        public static readonly Sound EntityCatAmbient = new Sound(155, "entity.cat.ambient");
        public static readonly Sound EntityCatDeath = new Sound(156, "entity.cat.death");
        public static readonly Sound EntityCatHiss = new Sound(157, "entity.cat.hiss");
        public static readonly Sound EntityCatHurt = new Sound(158, "entity.cat.hurt");
        public static readonly Sound EntityCatPurr = new Sound(159, "entity.cat.purr");
        public static readonly Sound EntityCatPurreow = new Sound(160, "entity.cat.purreow");
        public static readonly Sound EntityChickenAmbient = new Sound(161, "entity.chicken.ambient");
        public static readonly Sound EntityChickenDeath = new Sound(162, "entity.chicken.death");
        public static readonly Sound EntityChickenEgg = new Sound(163, "entity.chicken.egg");
        public static readonly Sound EntityChickenHurt = new Sound(164, "entity.chicken.hurt");
        public static readonly Sound EntityChickenStep = new Sound(165, "entity.chicken.step");
        public static readonly Sound EntityCowAmbient = new Sound(166, "entity.cow.ambient");
        public static readonly Sound EntityCowDeath = new Sound(167, "entity.cow.death");
        public static readonly Sound EntityCowHurt = new Sound(168, "entity.cow.hurt");
        public static readonly Sound EntityCowMilk = new Sound(169, "entity.cow.milk");
        public static readonly Sound EntityCowStep = new Sound(170, "entity.cow.step");
        public static readonly Sound EntityCreeperDeath = new Sound(171, "entity.creeper.death");
        public static readonly Sound EntityCreeperHurt = new Sound(172, "entity.creeper.hurt");
        public static readonly Sound EntityCreeperPrimed = new Sound(173, "entity.creeper.primed");
        public static readonly Sound EntityDonkeyAmbient = new Sound(174, "entity.donkey.ambient");
        public static readonly Sound EntityDonkeyAngry = new Sound(175, "entity.donkey.angry");
        public static readonly Sound EntityDonkeyChest = new Sound(176, "entity.donkey.chest");
        public static readonly Sound EntityDonkeyDeath = new Sound(177, "entity.donkey.death");
        public static readonly Sound EntityDonkeyHurt = new Sound(178, "entity.donkey.hurt");
        public static readonly Sound EntityEggThrow = new Sound(179, "entity.egg.throw");
        public static readonly Sound EntityElderGuardianAmbient = new Sound(180, "entity.elder_guardian.ambient");
        public static readonly Sound EntityElderGuardianAmbientLand = new Sound(181, "entity.elder_guardian.ambient_land");
        public static readonly Sound EntityElderGuardianCurse = new Sound(182, "entity.elder_guardian.curse");
        public static readonly Sound EntityElderGuardianDeath = new Sound(183, "entity.elder_guardian.death");
        public static readonly Sound EntityElderGuardianDeathLand = new Sound(184, "entity.elder_guardian.death_land");
        public static readonly Sound EntityElderGuardianFlop = new Sound(185, "entity.elder_guardian.flop");
        public static readonly Sound EntityElderGuardianHurt = new Sound(186, "entity.elder_guardian.hurt");
        public static readonly Sound EntityElderGuardianHurtLand = new Sound(187, "entity.elder_guardian.hurt_land");
        public static readonly Sound EntityEnderdragonAmbient = new Sound(188, "entity.enderdragon.ambient");
        public static readonly Sound EntityEnderdragonDeath = new Sound(189, "entity.enderdragon.death");
        public static readonly Sound EntityEnderdragonFlap = new Sound(190, "entity.enderdragon.flap");
        public static readonly Sound EntityEnderdragonGrowl = new Sound(191, "entity.enderdragon.growl");
        public static readonly Sound EntityEnderdragonHurt = new Sound(192, "entity.enderdragon.hurt");
        public static readonly Sound EntityEnderdragonShoot = new Sound(193, "entity.enderdragon.shoot");
        public static readonly Sound EntityEnderdragonFireballExplode = new Sound(194, "entity.enderdragon_fireball.explode");
        public static readonly Sound EntityEndereyeDeath = new Sound(195, "entity.endereye.death");
        public static readonly Sound EntityEndereyeLaunch = new Sound(196, "entity.endereye.launch");
        public static readonly Sound EntityEndermenAmbient = new Sound(197, "entity.endermen.ambient");
        public static readonly Sound EntityEndermenDeath = new Sound(198, "entity.endermen.death");
        public static readonly Sound EntityEndermenHurt = new Sound(199, "entity.endermen.hurt");
        public static readonly Sound EntityEndermenScream = new Sound(200, "entity.endermen.scream");
        public static readonly Sound EntityEndermenStare = new Sound(201, "entity.endermen.stare");
        public static readonly Sound EntityEndermenTeleport = new Sound(202, "entity.endermen.teleport");
        public static readonly Sound EntityEndermiteAmbient = new Sound(203, "entity.endermite.ambient");
        public static readonly Sound EntityEndermiteDeath = new Sound(204, "entity.endermite.death");
        public static readonly Sound EntityEndermiteHurt = new Sound(205, "entity.endermite.hurt");
        public static readonly Sound EntityEndermiteStep = new Sound(206, "entity.endermite.step");
        public static readonly Sound EntityEnderpearlThrow = new Sound(207, "entity.enderpearl.throw");
        public static readonly Sound EntityEvocationFangsAttack = new Sound(208, "entity.evocation_fangs.attack");
        public static readonly Sound EntityEvocationIllagerAmbient = new Sound(209, "entity.evocation_illager.ambient");
        public static readonly Sound EntityEvocationIllagerCastSpell = new Sound(210, "entity.evocation_illager.cast_spell");
        public static readonly Sound EntityEvocationIllagerDeath = new Sound(211, "entity.evocation_illager.death");
        public static readonly Sound EntityEvocationIllagerHurt = new Sound(212, "entity.evocation_illager.hurt");
        public static readonly Sound EntityEvocationIllagerPrepareAttack = new Sound(213, "entity.evocation_illager.prepare_attack");
        public static readonly Sound EntityEvocationIllagerPrepareSummon = new Sound(214, "entity.evocation_illager.prepare_summon");
        public static readonly Sound EntityEvocationIllagerPrepareWololo = new Sound(215, "entity.evocation_illager.prepare_wololo");
        public static readonly Sound EntityExperienceBottleThrow = new Sound(216, "entity.experience_bottle.throw");
        public static readonly Sound EntityExperienceOrbPickup = new Sound(217, "entity.experience_orb.pickup");
        public static readonly Sound EntityFireworkBlast = new Sound(218, "entity.firework.blast");
        public static readonly Sound EntityFireworkBlastFar = new Sound(219, "entity.firework.blast_far");
        public static readonly Sound EntityFireworkLargeBlast = new Sound(220, "entity.firework.large_blast");
        public static readonly Sound EntityFireworkLargeBlastFar = new Sound(221, "entity.firework.large_blast_far");
        public static readonly Sound EntityFireworkLaunch = new Sound(222, "entity.firework.launch");
        public static readonly Sound EntityFireworkShoot = new Sound(223, "entity.firework.shoot");
        public static readonly Sound EntityFireworkTwinkle = new Sound(224, "entity.firework.twinkle");
        public static readonly Sound EntityFireworkTwinkleFar = new Sound(225, "entity.firework.twinkle_far");
        public static readonly Sound EntityGenericBigFall = new Sound(226, "entity.generic.big_fall");
        public static readonly Sound EntityGenericBurn = new Sound(227, "entity.generic.burn");
        public static readonly Sound EntityGenericDeath = new Sound(228, "entity.generic.death");
        public static readonly Sound EntityGenericDrink = new Sound(229, "entity.generic.drink");
        public static readonly Sound EntityGenericEat = new Sound(230, "entity.generic.eat");
        public static readonly Sound EntityGenericExplode = new Sound(231, "entity.generic.explode");
        public static readonly Sound EntityGenericExtinguishFire = new Sound(232, "entity.generic.extinguish_fire");
        public static readonly Sound EntityGenericHurt = new Sound(233, "entity.generic.hurt");
        public static readonly Sound EntityGenericSmallFall = new Sound(234, "entity.generic.small_fall");
        public static readonly Sound EntityGenericSplash = new Sound(235, "entity.generic.splash");
        public static readonly Sound EntityGenericSwim = new Sound(236, "entity.generic.swim");
        public static readonly Sound EntityGhastAmbient = new Sound(237, "entity.ghast.ambient");
        public static readonly Sound EntityGhastDeath = new Sound(238, "entity.ghast.death");
        public static readonly Sound EntityGhastHurt = new Sound(239, "entity.ghast.hurt");
        public static readonly Sound EntityGhastScream = new Sound(240, "entity.ghast.scream");
        public static readonly Sound EntityGhastShoot = new Sound(241, "entity.ghast.shoot");
        public static readonly Sound EntityGhastWarn = new Sound(242, "entity.ghast.warn");
        public static readonly Sound EntityGuardianAmbient = new Sound(243, "entity.guardian.ambient");
        public static readonly Sound EntityGuardianAmbientLand = new Sound(244, "entity.guardian.ambient_land");
        public static readonly Sound EntityGuardianAttack = new Sound(245, "entity.guardian.attack");
        public static readonly Sound EntityGuardianDeath = new Sound(246, "entity.guardian.death");
        public static readonly Sound EntityGuardianDeathLand = new Sound(247, "entity.guardian.death_land");
        public static readonly Sound EntityGuardianFlop = new Sound(248, "entity.guardian.flop");
        public static readonly Sound EntityGuardianHurt = new Sound(249, "entity.guardian.hurt");
        public static readonly Sound EntityGuardianHurtLand = new Sound(250, "entity.guardian.hurt_land");
        public static readonly Sound EntityHorseAmbient = new Sound(251, "entity.horse.ambient");
        public static readonly Sound EntityHorseAngry = new Sound(252, "entity.horse.angry");
        public static readonly Sound EntityHorseArmor = new Sound(253, "entity.horse.armor");
        public static readonly Sound EntityHorseBreathe = new Sound(254, "entity.horse.breathe");
        public static readonly Sound EntityHorseDeath = new Sound(255, "entity.horse.death");
        public static readonly Sound EntityHorseEat = new Sound(256, "entity.horse.eat");
        public static readonly Sound EntityHorseGallop = new Sound(257, "entity.horse.gallop");
        public static readonly Sound EntityHorseHurt = new Sound(258, "entity.horse.hurt");
        public static readonly Sound EntityHorseJump = new Sound(259, "entity.horse.jump");
        public static readonly Sound EntityHorseLand = new Sound(260, "entity.horse.land");
        public static readonly Sound EntityHorseSaddle = new Sound(261, "entity.horse.saddle");
        public static readonly Sound EntityHorseStep = new Sound(262, "entity.horse.step");
        public static readonly Sound EntityHorseStepWood = new Sound(263, "entity.horse.step_wood");
        public static readonly Sound EntityHostileBigFall = new Sound(264, "entity.hostile.big_fall");
        public static readonly Sound EntityHostileDeath = new Sound(265, "entity.hostile.death");
        public static readonly Sound EntityHostileHurt = new Sound(266, "entity.hostile.hurt");
        public static readonly Sound EntityHostileSmallFall = new Sound(267, "entity.hostile.small_fall");
        public static readonly Sound EntityHostileSplash = new Sound(268, "entity.hostile.splash");
        public static readonly Sound EntityHostileSwim = new Sound(269, "entity.hostile.swim");
        public static readonly Sound EntityHuskAmbient = new Sound(270, "entity.husk.ambient");
        public static readonly Sound EntityHuskDeath = new Sound(271, "entity.husk.death");
        public static readonly Sound EntityHuskHurt = new Sound(272, "entity.husk.hurt");
        public static readonly Sound EntityHuskStep = new Sound(273, "entity.husk.step");
        public static readonly Sound EntityIllusionIllagerAmbient = new Sound(274, "entity.illusion_illager.ambient");
        public static readonly Sound EntityIllusionIllagerCastSpell = new Sound(275, "entity.illusion_illager.cast_spell");
        public static readonly Sound EntityIllusionIllagerDeath = new Sound(276, "entity.illusion_illager.death");
        public static readonly Sound EntityIllusionIllagerHurt = new Sound(277, "entity.illusion_illager.hurt");
        public static readonly Sound EntityIllusionIllagerMirrorMove = new Sound(278, "entity.illusion_illager.mirror_move");
        public static readonly Sound EntityIllusionIllagerPrepareBlindness = new Sound(279, "entity.illusion_illager.prepare_blindness");
        public static readonly Sound EntityIllusionIllagerPrepareMirror = new Sound(280, "entity.illusion_illager.prepare_mirror");
        public static readonly Sound EntityIrongolemAttack = new Sound(281, "entity.irongolem.attack");
        public static readonly Sound EntityIrongolemDeath = new Sound(282, "entity.irongolem.death");
        public static readonly Sound EntityIrongolemHurt = new Sound(283, "entity.irongolem.hurt");
        public static readonly Sound EntityIrongolemStep = new Sound(284, "entity.irongolem.step");
        public static readonly Sound EntityItemBreak = new Sound(285, "entity.item.break");
        public static readonly Sound EntityItemPickup = new Sound(286, "entity.item.pickup");
        public static readonly Sound EntityItemframeAddItem = new Sound(287, "entity.itemframe.add_item");
        public static readonly Sound EntityItemframeBreak = new Sound(288, "entity.itemframe.break");
        public static readonly Sound EntityItemframePlace = new Sound(289, "entity.itemframe.place");
        public static readonly Sound EntityItemframeRemoveItem = new Sound(290, "entity.itemframe.remove_item");
        public static readonly Sound EntityItemframeRotateItem = new Sound(291, "entity.itemframe.rotate_item");
        public static readonly Sound EntityLeashknotBreak = new Sound(292, "entity.leashknot.break");
        public static readonly Sound EntityLeashknotPlace = new Sound(293, "entity.leashknot.place");
        public static readonly Sound EntityLightningImpact = new Sound(294, "entity.lightning.impact");
        public static readonly Sound EntityLightningThunder = new Sound(295, "entity.lightning.thunder");
        public static readonly Sound EntityLingeringpotionThrow = new Sound(296, "entity.lingeringpotion.throw");
        public static readonly Sound EntityLlamaAmbient = new Sound(297, "entity.llama.ambient");
        public static readonly Sound EntityLlamaAngry = new Sound(298, "entity.llama.angry");
        public static readonly Sound EntityLlamaChest = new Sound(299, "entity.llama.chest");
        public static readonly Sound EntityLlamaDeath = new Sound(300, "entity.llama.death");
        public static readonly Sound EntityLlamaEat = new Sound(301, "entity.llama.eat");
        public static readonly Sound EntityLlamaHurt = new Sound(302, "entity.llama.hurt");
        public static readonly Sound EntityLlamaSpit = new Sound(303, "entity.llama.spit");
        public static readonly Sound EntityLlamaStep = new Sound(304, "entity.llama.step");
        public static readonly Sound EntityLlamaSwag = new Sound(305, "entity.llama.swag");
        public static readonly Sound EntityMagmacubeDeath = new Sound(306, "entity.magmacube.death");
        public static readonly Sound EntityMagmacubeHurt = new Sound(307, "entity.magmacube.hurt");
        public static readonly Sound EntityMagmacubeJump = new Sound(308, "entity.magmacube.jump");
        public static readonly Sound EntityMagmacubeSquish = new Sound(309, "entity.magmacube.squish");
        public static readonly Sound EntityMinecartInside = new Sound(310, "entity.minecart.inside");
        public static readonly Sound EntityMinecartRiding = new Sound(311, "entity.minecart.riding");
        public static readonly Sound EntityMooshroomShear = new Sound(312, "entity.mooshroom.shear");
        public static readonly Sound EntityMuleAmbient = new Sound(313, "entity.mule.ambient");
        public static readonly Sound EntityMuleChest = new Sound(314, "entity.mule.chest");
        public static readonly Sound EntityMuleDeath = new Sound(315, "entity.mule.death");
        public static readonly Sound EntityMuleHurt = new Sound(316, "entity.mule.hurt");
        public static readonly Sound EntityPaintingBreak = new Sound(317, "entity.painting.break");
        public static readonly Sound EntityPaintingPlace = new Sound(318, "entity.painting.place");
        public static readonly Sound EntityParrotAmbient = new Sound(319, "entity.parrot.ambient");
        public static readonly Sound EntityParrotDeath = new Sound(320, "entity.parrot.death");
        public static readonly Sound EntityParrotEat = new Sound(321, "entity.parrot.eat");
        public static readonly Sound EntityParrotFly = new Sound(322, "entity.parrot.fly");
        public static readonly Sound EntityParrotHurt = new Sound(323, "entity.parrot.hurt");
        public static readonly Sound EntityParrotImitateBlaze = new Sound(324, "entity.parrot.imitate.blaze");
        public static readonly Sound EntityParrotImitateCreeper = new Sound(325, "entity.parrot.imitate.creeper");
        public static readonly Sound EntityParrotImitateElderGuardian = new Sound(326, "entity.parrot.imitate.elder_guardian");
        public static readonly Sound EntityParrotImitateEnderdragon = new Sound(327, "entity.parrot.imitate.enderdragon");
        public static readonly Sound EntityParrotImitateEnderman = new Sound(328, "entity.parrot.imitate.enderman");
        public static readonly Sound EntityParrotImitateEndermite = new Sound(329, "entity.parrot.imitate.endermite");
        public static readonly Sound EntityParrotImitateEvocationIllager = new Sound(330, "entity.parrot.imitate.evocation_illager");
        public static readonly Sound EntityParrotImitateGhast = new Sound(331, "entity.parrot.imitate.ghast");
        public static readonly Sound EntityParrotImitateHusk = new Sound(332, "entity.parrot.imitate.husk");
        public static readonly Sound EntityParrotImitateIllusionIllager = new Sound(333, "entity.parrot.imitate.illusion_illager");
        public static readonly Sound EntityParrotImitateMagmacube = new Sound(334, "entity.parrot.imitate.magmacube");
        public static readonly Sound EntityParrotImitatePolarBear = new Sound(335, "entity.parrot.imitate.polar_bear");
        public static readonly Sound EntityParrotImitateShulker = new Sound(336, "entity.parrot.imitate.shulker");
        public static readonly Sound EntityParrotImitateSilverfish = new Sound(337, "entity.parrot.imitate.silverfish");
        public static readonly Sound EntityParrotImitateSkeleton = new Sound(338, "entity.parrot.imitate.skeleton");
        public static readonly Sound EntityParrotImitateSlime = new Sound(339, "entity.parrot.imitate.slime");
        public static readonly Sound EntityParrotImitateSpider = new Sound(340, "entity.parrot.imitate.spider");
        public static readonly Sound EntityParrotImitateStray = new Sound(341, "entity.parrot.imitate.stray");
        public static readonly Sound EntityParrotImitateVex = new Sound(342, "entity.parrot.imitate.vex");
        public static readonly Sound EntityParrotImitateVindicationIllager = new Sound(343, "entity.parrot.imitate.vindication_illager");
        public static readonly Sound EntityParrotImitateWitch = new Sound(344, "entity.parrot.imitate.witch");
        public static readonly Sound EntityParrotImitateWither = new Sound(345, "entity.parrot.imitate.wither");
        public static readonly Sound EntityParrotImitateWitherSkeleton = new Sound(346, "entity.parrot.imitate.wither_skeleton");
        public static readonly Sound EntityParrotImitateWolf = new Sound(347, "entity.parrot.imitate.wolf");
        public static readonly Sound EntityParrotImitateZombie = new Sound(348, "entity.parrot.imitate.zombie");
        public static readonly Sound EntityParrotImitateZombiePigman = new Sound(349, "entity.parrot.imitate.zombie_pigman");
        public static readonly Sound EntityParrotImitateZombieVillager = new Sound(350, "entity.parrot.imitate.zombie_villager");
        public static readonly Sound EntityParrotStep = new Sound(351, "entity.parrot.step");
        public static readonly Sound EntityPigAmbient = new Sound(352, "entity.pig.ambient");
        public static readonly Sound EntityPigDeath = new Sound(353, "entity.pig.death");
        public static readonly Sound EntityPigHurt = new Sound(354, "entity.pig.hurt");
        public static readonly Sound EntityPigSaddle = new Sound(355, "entity.pig.saddle");
        public static readonly Sound EntityPigStep = new Sound(356, "entity.pig.step");
        public static readonly Sound EntityPlayerAttackCrit = new Sound(357, "entity.player.attack.crit");
        public static readonly Sound EntityPlayerAttackKnockback = new Sound(358, "entity.player.attack.knockback");
        public static readonly Sound EntityPlayerAttackNodamage = new Sound(359, "entity.player.attack.nodamage");
        public static readonly Sound EntityPlayerAttackStrong = new Sound(360, "entity.player.attack.strong");
        public static readonly Sound EntityPlayerAttackSweep = new Sound(361, "entity.player.attack.sweep");
        public static readonly Sound EntityPlayerAttackWeak = new Sound(362, "entity.player.attack.weak");
        public static readonly Sound EntityPlayerBigFall = new Sound(363, "entity.player.big_fall");
        public static readonly Sound EntityPlayerBreath = new Sound(364, "entity.player.breath");
        public static readonly Sound EntityPlayerBurp = new Sound(365, "entity.player.burp");
        public static readonly Sound EntityPlayerDeath = new Sound(366, "entity.player.death");
        public static readonly Sound EntityPlayerHurt = new Sound(367, "entity.player.hurt");
        public static readonly Sound EntityPlayerHurtDrown = new Sound(368, "entity.player.hurt_drown");
        public static readonly Sound EntityPlayerHurtonFire = new Sound(369, "entity.player.hurt_on_fire");
        public static readonly Sound EntityPlayerLevelup = new Sound(370, "entity.player.levelup");
        public static readonly Sound EntityPlayerSmallFall = new Sound(371, "entity.player.small_fall");
        public static readonly Sound EntityPlayerSplash = new Sound(372, "entity.player.splash");
        public static readonly Sound EntityPlayerSwim = new Sound(373, "entity.player.swim");
        public static readonly Sound EntityPolarBearAmbient = new Sound(374, "entity.polar_bear.ambient");
        public static readonly Sound EntityPolarBearBabyAmbient = new Sound(375, "entity.polar_bear.baby_ambient");
        public static readonly Sound EntityPolarBearDeath = new Sound(376, "entity.polar_bear.death");
        public static readonly Sound EntityPolarBearHurt = new Sound(377, "entity.polar_bear.hurt");
        public static readonly Sound EntityPolarBearStep = new Sound(378, "entity.polar_bear.step");
        public static readonly Sound EntityPolarBearWarning = new Sound(379, "entity.polar_bear.warning");
        public static readonly Sound EntityRabbitAmbient = new Sound(380, "entity.rabbit.ambient");
        public static readonly Sound EntityRabbitAttack = new Sound(381, "entity.rabbit.attack");
        public static readonly Sound EntityRabbitDeath = new Sound(382, "entity.rabbit.death");
        public static readonly Sound EntityRabbitHurt = new Sound(383, "entity.rabbit.hurt");
        public static readonly Sound EntityRabbitJump = new Sound(384, "entity.rabbit.jump");
        public static readonly Sound EntitySheepAmbient = new Sound(385, "entity.sheep.ambient");
        public static readonly Sound EntitySheepDeath = new Sound(386, "entity.sheep.death");
        public static readonly Sound EntitySheepHurt = new Sound(387, "entity.sheep.hurt");
        public static readonly Sound EntitySheepShear = new Sound(388, "entity.sheep.shear");
        public static readonly Sound EntitySheepStep = new Sound(389, "entity.sheep.step");
        public static readonly Sound EntityShulkerAmbient = new Sound(390, "entity.shulker.ambient");
        public static readonly Sound EntityShulkerClose = new Sound(391, "entity.shulker.close");
        public static readonly Sound EntityShulkerDeath = new Sound(392, "entity.shulker.death");
        public static readonly Sound EntityShulkerHurt = new Sound(393, "entity.shulker.hurt");
        public static readonly Sound EntityShulkerHurtClosed = new Sound(394, "entity.shulker.hurt_closed");
        public static readonly Sound EntityShulkerOpen = new Sound(395, "entity.shulker.open");
        public static readonly Sound EntityShulkerShoot = new Sound(396, "entity.shulker.shoot");
        public static readonly Sound EntityShulkerTeleport = new Sound(397, "entity.shulker.teleport");
        public static readonly Sound EntityShulkerBulletHit = new Sound(398, "entity.shulker_bullet.hit");
        public static readonly Sound EntityShulkerBulletHurt = new Sound(399, "entity.shulker_bullet.hurt");
        public static readonly Sound EntitySilverfishAmbient = new Sound(400, "entity.silverfish.ambient");
        public static readonly Sound EntitySilverfishDeath = new Sound(401, "entity.silverfish.death");
        public static readonly Sound EntitySilverfishHurt = new Sound(402, "entity.silverfish.hurt");
        public static readonly Sound EntitySilverfishStep = new Sound(403, "entity.silverfish.step");
        public static readonly Sound EntitySkeletonAmbient = new Sound(404, "entity.skeleton.ambient");
        public static readonly Sound EntitySkeletonDeath = new Sound(405, "entity.skeleton.death");
        public static readonly Sound EntitySkeletonHurt = new Sound(406, "entity.skeleton.hurt");
        public static readonly Sound EntitySkeletonShoot = new Sound(407, "entity.skeleton.shoot");
        public static readonly Sound EntitySkeletonStep = new Sound(408, "entity.skeleton.step");
        public static readonly Sound EntitySkeletonHorseAmbient = new Sound(409, "entity.skeleton_horse.ambient");
        public static readonly Sound EntitySkeletonHorseDeath = new Sound(410, "entity.skeleton_horse.death");
        public static readonly Sound EntitySkeletonHorseHurt = new Sound(411, "entity.skeleton_horse.hurt");
        public static readonly Sound EntitySlimeAttack = new Sound(412, "entity.slime.attack");
        public static readonly Sound EntitySlimeDeath = new Sound(413, "entity.slime.death");
        public static readonly Sound EntitySlimeHurt = new Sound(414, "entity.slime.hurt");
        public static readonly Sound EntitySlimeJump = new Sound(415, "entity.slime.jump");
        public static readonly Sound EntitySlimeSquish = new Sound(416, "entity.slime.squish");
        public static readonly Sound EntitySmallMagmacubeDeath = new Sound(417, "entity.small_magmacube.death");
        public static readonly Sound EntitySmallMagmacubeHurt = new Sound(418, "entity.small_magmacube.hurt");
        public static readonly Sound EntitySmallMagmacubeSquish = new Sound(419, "entity.small_magmacube.squish");
        public static readonly Sound EntitySmallSlimeDeath = new Sound(420, "entity.small_slime.death");
        public static readonly Sound EntitySmallSlimeHurt = new Sound(421, "entity.small_slime.hurt");
        public static readonly Sound EntitySmallSlimeJump = new Sound(422, "entity.small_slime.jump");
        public static readonly Sound EntitySmallSlimeSquish = new Sound(423, "entity.small_slime.squish");
        public static readonly Sound EntitySnowballThrow = new Sound(424, "entity.snowball.throw");
        public static readonly Sound EntitySnowmanAmbient = new Sound(425, "entity.snowman.ambient");
        public static readonly Sound EntitySnowmanDeath = new Sound(426, "entity.snowman.death");
        public static readonly Sound EntitySnowmanHurt = new Sound(427, "entity.snowman.hurt");
        public static readonly Sound EntitySnowmanShoot = new Sound(428, "entity.snowman.shoot");
        public static readonly Sound EntitySpiderAmbient = new Sound(429, "entity.spider.ambient");
        public static readonly Sound EntitySpiderDeath = new Sound(430, "entity.spider.death");
        public static readonly Sound EntitySpiderHurt = new Sound(431, "entity.spider.hurt");
        public static readonly Sound EntitySpiderStep = new Sound(432, "entity.spider.step");
        public static readonly Sound EntitySplashPotionBreak = new Sound(433, "entity.splash_potion.break");
        public static readonly Sound EntitySplashPotionThrow = new Sound(434, "entity.splash_potion.throw");
        public static readonly Sound EntitySquidAmbient = new Sound(435, "entity.squid.ambient");
        public static readonly Sound EntitySquidDeath = new Sound(436, "entity.squid.death");
        public static readonly Sound EntitySquidHurt = new Sound(437, "entity.squid.hurt");
        public static readonly Sound EntityStrayAmbient = new Sound(438, "entity.stray.ambient");
        public static readonly Sound EntityStrayDeath = new Sound(439, "entity.stray.death");
        public static readonly Sound EntityStrayHurt = new Sound(440, "entity.stray.hurt");
        public static readonly Sound EntityStrayStep = new Sound(441, "entity.stray.step");
        public static readonly Sound EntityTntPrimed = new Sound(442, "entity.tnt.primed");
        public static readonly Sound EntityVexAmbient = new Sound(443, "entity.vex.ambient");
        public static readonly Sound EntityVexCharge = new Sound(444, "entity.vex.charge");
        public static readonly Sound EntityVexDeath = new Sound(445, "entity.vex.death");
        public static readonly Sound EntityVexHurt = new Sound(446, "entity.vex.hurt");
        public static readonly Sound EntityVillagerAmbient = new Sound(447, "entity.villager.ambient");
        public static readonly Sound EntityVillagerDeath = new Sound(448, "entity.villager.death");
        public static readonly Sound EntityVillagerHurt = new Sound(449, "entity.villager.hurt");
        public static readonly Sound EntityVillagerNo = new Sound(450, "entity.villager.no");
        public static readonly Sound EntityVillagerTrading = new Sound(451, "entity.villager.trading");
        public static readonly Sound EntityVillagerYes = new Sound(452, "entity.villager.yes");
        public static readonly Sound EntityVindicationIllagerAmbient = new Sound(453, "entity.vindication_illager.ambient");
        public static readonly Sound EntityVindicationIllagerDeath = new Sound(454, "entity.vindication_illager.death");
        public static readonly Sound EntityVindicationIllagerHurt = new Sound(455, "entity.vindication_illager.hurt");
        public static readonly Sound EntityWitchAmbient = new Sound(456, "entity.witch.ambient");
        public static readonly Sound EntityWitchDeath = new Sound(457, "entity.witch.death");
        public static readonly Sound EntityWitchDrink = new Sound(458, "entity.witch.drink");
        public static readonly Sound EntityWitchHurt = new Sound(459, "entity.witch.hurt");
        public static readonly Sound EntityWitchThrow = new Sound(460, "entity.witch.throw");
        public static readonly Sound EntityWitherAmbient = new Sound(461, "entity.wither.ambient");
        public static readonly Sound EntityWitherBreakBlock = new Sound(462, "entity.wither.break_block");
        public static readonly Sound EntityWitherDeath = new Sound(463, "entity.wither.death");
        public static readonly Sound EntityWitherHurt = new Sound(464, "entity.wither.hurt");
        public static readonly Sound EntityWitherShoot = new Sound(465, "entity.wither.shoot");
        public static readonly Sound EntityWitherSpawn = new Sound(466, "entity.wither.spawn");
        public static readonly Sound EntityWitherSkeletonAmbient = new Sound(467, "entity.wither_skeleton.ambient");
        public static readonly Sound EntityWitherSkeletonDeath = new Sound(468, "entity.wither_skeleton.death");
        public static readonly Sound EntityWitherSkeletonHurt = new Sound(469, "entity.wither_skeleton.hurt");
        public static readonly Sound EntityWitherSkeletonStep = new Sound(470, "entity.wither_skeleton.step");
        public static readonly Sound EntityWolfAmbient = new Sound(471, "entity.wolf.ambient");
        public static readonly Sound EntityWolfDeath = new Sound(472, "entity.wolf.death");
        public static readonly Sound EntityWolfGrowl = new Sound(473, "entity.wolf.growl");
        public static readonly Sound EntityWolfHowl = new Sound(474, "entity.wolf.howl");
        public static readonly Sound EntityWolfHurt = new Sound(475, "entity.wolf.hurt");
        public static readonly Sound EntityWolfPant = new Sound(476, "entity.wolf.pant");
        public static readonly Sound EntityWolfShake = new Sound(477, "entity.wolf.shake");
        public static readonly Sound EntityWolfStep = new Sound(478, "entity.wolf.step");
        public static readonly Sound EntityWolfWhine = new Sound(479, "entity.wolf.whine");
        public static readonly Sound EntityZombieAmbient = new Sound(480, "entity.zombie.ambient");
        public static readonly Sound EntityZombieAttackDoorWood = new Sound(481, "entity.zombie.attack_door_wood");
        public static readonly Sound EntityZombieAttackIronDoor = new Sound(482, "entity.zombie.attack_iron_door");
        public static readonly Sound EntityZombieBreakDoorWood = new Sound(483, "entity.zombie.break_door_wood");
        public static readonly Sound EntityZombieDeath = new Sound(484, "entity.zombie.death");
        public static readonly Sound EntityZombieHurt = new Sound(485, "entity.zombie.hurt");
        public static readonly Sound EntityZombieInfect = new Sound(486, "entity.zombie.infect");
        public static readonly Sound EntityZombieStep = new Sound(487, "entity.zombie.step");
        public static readonly Sound EntityZombieHorseAmbient = new Sound(488, "entity.zombie_horse.ambient");
        public static readonly Sound EntityZombieHorseDeath = new Sound(489, "entity.zombie_horse.death");
        public static readonly Sound EntityZombieHorseHurt = new Sound(490, "entity.zombie_horse.hurt");
        public static readonly Sound EntityZombiePigAmbient = new Sound(491, "entity.zombie_pig.ambient");
        public static readonly Sound EntityZombiePigAngry = new Sound(492, "entity.zombie_pig.angry");
        public static readonly Sound EntityZombiePigDeath = new Sound(493, "entity.zombie_pig.death");
        public static readonly Sound EntityZombiePigHurt = new Sound(494, "entity.zombie_pig.hurt");
        public static readonly Sound EntityZombieVillagerAmbient = new Sound(495, "entity.zombie_villager.ambient");
        public static readonly Sound EntityZombieVillagerConverted = new Sound(496, "entity.zombie_villager.converted");
        public static readonly Sound EntityZombieVillagerCure = new Sound(497, "entity.zombie_villager.cure");
        public static readonly Sound EntityZombieVillagerDeath = new Sound(498, "entity.zombie_villager.death");
        public static readonly Sound EntityZombieVillagerHurt = new Sound(499, "entity.zombie_villager.hurt");
        public static readonly Sound EntityZombieVillagerStep = new Sound(500, "entity.zombie_villager.step");
        public static readonly Sound ItemArmorEquipChain = new Sound(501, "item.armor.equip_chain");
        public static readonly Sound ItemArmorEquipDiamond = new Sound(502, "item.armor.equip_diamond");
        public static readonly Sound ItemArmorEquipElytra = new Sound(503, "item.armor.equip_elytra");
        public static readonly Sound ItemArmorEquipGeneric = new Sound(504, "item.armor.equip_generic");
        public static readonly Sound ItemArmorEquipGold = new Sound(505, "item.armor.equip_gold");
        public static readonly Sound ItemArmorEquipIron = new Sound(506, "item.armor.equip_iron");
        public static readonly Sound ItemArmorEquipLeather = new Sound(507, "item.armor.equip_leather");
        public static readonly Sound ItemBottleEmpty = new Sound(508, "item.bottle.empty");
        public static readonly Sound ItemBottleFill = new Sound(509, "item.bottle.fill");
        public static readonly Sound ItemBottleFillDragonbreath = new Sound(510, "item.bottle.fill_dragonbreath");
        public static readonly Sound ItemBucketEmpty = new Sound(511, "item.bucket.empty");
        public static readonly Sound ItemBucketEmptyLava = new Sound(512, "item.bucket.empty_lava");
        public static readonly Sound ItemBucketFill = new Sound(513, "item.bucket.fill");
        public static readonly Sound ItemBucketFillLava = new Sound(514, "item.bucket.fill_lava");
        public static readonly Sound ItemChorusFruitTeleport = new Sound(515, "item.chorus_fruit.teleport");
        public static readonly Sound ItemElytraFlying = new Sound(516, "item.elytra.flying");
        public static readonly Sound ItemFirechargeUse = new Sound(517, "item.firecharge.use");
        public static readonly Sound ItemFlintandsteelUse = new Sound(518, "item.flintandsteel.use");
        public static readonly Sound ItemHoeTill = new Sound(519, "item.hoe.till");
        public static readonly Sound ItemShieldBlock = new Sound(520, "item.shield.block");
        public static readonly Sound ItemShieldBreak = new Sound(521, "item.shield.break");
        public static readonly Sound ItemShovelFlatten = new Sound(522, "item.shovel.flatten");
        public static readonly Sound ItemTotemUse = new Sound(523, "item.totem.use");
        public static readonly Sound MusicCreative = new Sound(524, "music.creative");
        public static readonly Sound MusicCredits = new Sound(525, "music.credits");
        public static readonly Sound MusicDragon = new Sound(526, "music.dragon");
        public static readonly Sound MusicEnd = new Sound(527, "music.end");
        public static readonly Sound MusicGame = new Sound(528, "music.game");
        public static readonly Sound MusicMenu = new Sound(529, "music.menu");
        public static readonly Sound MusicNether = new Sound(530, "music.nether");
        public static readonly Sound Record11 = new Sound(531, "record.11");
        public static readonly Sound Record13 = new Sound(532, "record.13");
        public static readonly Sound RecordBlocks = new Sound(533, "record.blocks");
        public static readonly Sound RecordCat = new Sound(534, "record.cat");
        public static readonly Sound RecordChirp = new Sound(535, "record.chirp");
        public static readonly Sound RecordFar = new Sound(536, "record.far");
        public static readonly Sound RecordMall = new Sound(537, "record.mall");
        public static readonly Sound RecordMellohi = new Sound(538, "record.mellohi");
        public static readonly Sound RecordStal = new Sound(539, "record.stal");
        public static readonly Sound RecordStrad = new Sound(540, "record.strad");
        public static readonly Sound RecordWait = new Sound(541, "record.wait");
        public static readonly Sound RecordWard = new Sound(542, "record.ward");
        public static readonly Sound UiButtonClick = new Sound(543, "ui.button.click");
        public static readonly Sound UiToastChallengeComplete = new Sound(544, "ui.toast.challenge_complete");
        public static readonly Sound UiToastIn = new Sound(545, "ui.toast.in");
        public static readonly Sound UiToastOut = new Sound(546, "ui.toast.out");
        public static readonly Sound WeatherRain = new Sound(547, "weather.rain");
        public static readonly Sound WeatherRainAbove = new Sound(548, "weather.rain.above");

        public static readonly Sound[] Values =
        {
            AmbientCave, BlockAnvilBreak, BlockAnvilDestroy, BlockAnvilFall, BlockAnvilHit, BlockAnvilLand, BlockAnvilPlace, BlockAnvilStep, BlockAnvilUse,
            BlockBrewingStandBrew, BlockChestClose, BlockChestLocked, BlockChestOpen, BlockChorusFlowerDeath, BlockChorusFlowerGrow, BlockClothBreak,
            BlockClothFall, BlockClothHit, BlockClothPlace, BlockClothStep, BlockComparatorClick, BlockDispenserDispense, BlockDispenserFail,
            BlockDispenserLaunch, BlockEnchantmentTableUse, BlockEndGatewaySpawn, BlockEndPortalSpawn, BlockEndPortalFrameFill, BlockEnderchestClose,
            BlockEnderchestOpen, BlockFenceGateClose, BlockFenceGateOpen, BlockFireAmbient, BlockFireExtinguish, BlockFurnaceFireCrackle, BlockGlassBreak,
            BlockGlassFall, BlockGlassHit, BlockGlassPlace, BlockGlassStep, BlockGrassBreak, BlockGrassFall, BlockGrassHit, BlockGrassPlace, BlockGrassStep,
            BlockGravelBreak, BlockGravelFall, BlockGravelHit, BlockGravelPlace, BlockGravelStep, BlockIronDoorClose, BlockIronDoorOpen, BlockIronTrapdoorClose,
            BlockIronTrapdoorOpen, BlockLadderBreak, BlockLadderFall, BlockLadderHit, BlockLadderPlace, BlockLadderStep, BlockLavaAmbient, BlockLavaExtinguish,
            BlockLavaPop, BlockLeverClick, BlockMetalBreak, BlockMetalFall, BlockMetalHit, BlockMetalPlace, BlockMetalStep, BlockMetalPressureplateClickOff,
            BlockMetalPressureplateClickOn, BlockNoteBasedrum, BlockNoteBass, BlockNoteBell, BlockNoteChime, BlockNoteFlute, BlockNoteGuitar, BlockNoteHarp,
            BlockNoteHat, BlockNotePling, BlockNoteSnare, BlockNoteXylophone, BlockPistonContract, BlockPistonExtend, BlockPortalAmbient, BlockPortalTravel,
            BlockPortalTrigger, BlockRedstoneTorchBurnout, BlockSandBreak, BlockSandFall, BlockSandHit, BlockSandPlace, BlockSandStep, BlockShulkerBoxClose,
            BlockShulkerBoxOpen, BlockSlimeBreak, BlockSlimeFall, BlockSlimeHit, BlockSlimePlace, BlockSlimeStep, BlockSnowBreak, BlockSnowFall, BlockSnowHit,
            BlockSnowPlace, BlockSnowStep, BlockStoneBreak, BlockStoneFall, BlockStoneHit, BlockStonePlace, BlockStoneStep, BlockStoneButtonClickOff,
            BlockStoneButtonClickOn, BlockStonePressureplateClickOff, BlockStonePressureplateClickOn, BlockTripwireAttach, BlockTripwireClickOff,
            BlockTripwireClickOn, BlockTripwireDetach, BlockWaterAmbient, BlockWaterlilyPlace, BlockWoodBreak, BlockWoodFall, BlockWoodHit, BlockWoodPlace,
            BlockWoodStep, BlockWoodButtonClickOff, BlockWoodButtonClickOn, BlockWoodPressureplateClickOff, BlockWoodPressureplateClickOn, BlockWoodenDoorClose,
            BlockWoodenDoorOpen, BlockWoodenTrapdoorClose, BlockWoodenTrapdoorOpen, EnchantThornsHit, EntityArmorstandBreak, EntityArmorstandFall,
            EntityArmorstandHit, EntityArmorstandPlace, EntityArrowHit, EntityArrowHitPlayer, EntityArrowShoot, EntityBatAmbient, EntityBatDeath, EntityBatHurt,
            EntityBatLoop, EntityBatTakeoff, EntityBlazeAmbient, EntityBlazeBurn, EntityBlazeDeath, EntityBlazeHurt, EntityBlazeShoot, EntityBoatPaddleLand,
            EntityBoatPaddleWater, EntityBobberRetrieve, EntityBobberSplash, EntityBobberThrow, EntityCatAmbient, EntityCatDeath, EntityCatHiss, EntityCatHurt,
            EntityCatPurr, EntityCatPurreow, EntityChickenAmbient, EntityChickenDeath, EntityChickenEgg, EntityChickenHurt, EntityChickenStep, EntityCowAmbient,
            EntityCowDeath, EntityCowHurt, EntityCowMilk, EntityCowStep, EntityCreeperDeath, EntityCreeperHurt, EntityCreeperPrimed, EntityDonkeyAmbient,
            EntityDonkeyAngry, EntityDonkeyChest, EntityDonkeyDeath, EntityDonkeyHurt, EntityEggThrow, EntityElderGuardianAmbient,
            EntityElderGuardianAmbientLand, EntityElderGuardianCurse, EntityElderGuardianDeath, EntityElderGuardianDeathLand, EntityElderGuardianFlop,
            EntityElderGuardianHurt, EntityElderGuardianHurtLand, EntityEnderdragonAmbient, EntityEnderdragonDeath, EntityEnderdragonFlap,
            EntityEnderdragonGrowl, EntityEnderdragonHurt, EntityEnderdragonShoot, EntityEnderdragonFireballExplode, EntityEndereyeDeath, EntityEndereyeLaunch,
            EntityEndermenAmbient, EntityEndermenDeath, EntityEndermenHurt, EntityEndermenScream, EntityEndermenStare, EntityEndermenTeleport,
            EntityEndermiteAmbient, EntityEndermiteDeath, EntityEndermiteHurt, EntityEndermiteStep, EntityEnderpearlThrow, EntityEvocationFangsAttack,
            EntityEvocationIllagerAmbient, EntityEvocationIllagerCastSpell, EntityEvocationIllagerDeath, EntityEvocationIllagerHurt,
            EntityEvocationIllagerPrepareAttack, EntityEvocationIllagerPrepareSummon, EntityEvocationIllagerPrepareWololo, EntityExperienceBottleThrow,
            EntityExperienceOrbPickup, EntityFireworkBlast, EntityFireworkBlastFar, EntityFireworkLargeBlast, EntityFireworkLargeBlastFar, EntityFireworkLaunch,
            EntityFireworkShoot, EntityFireworkTwinkle, EntityFireworkTwinkleFar, EntityGenericBigFall, EntityGenericBurn, EntityGenericDeath,
            EntityGenericDrink, EntityGenericEat, EntityGenericExplode, EntityGenericExtinguishFire, EntityGenericHurt, EntityGenericSmallFall,
            EntityGenericSplash, EntityGenericSwim, EntityGhastAmbient, EntityGhastDeath, EntityGhastHurt, EntityGhastScream, EntityGhastShoot, EntityGhastWarn,
            EntityGuardianAmbient, EntityGuardianAmbientLand, EntityGuardianAttack, EntityGuardianDeath, EntityGuardianDeathLand, EntityGuardianFlop,
            EntityGuardianHurt, EntityGuardianHurtLand, EntityHorseAmbient, EntityHorseAngry, EntityHorseArmor, EntityHorseBreathe, EntityHorseDeath,
            EntityHorseEat, EntityHorseGallop, EntityHorseHurt, EntityHorseJump, EntityHorseLand, EntityHorseSaddle, EntityHorseStep, EntityHorseStepWood,
            EntityHostileBigFall, EntityHostileDeath, EntityHostileHurt, EntityHostileSmallFall, EntityHostileSplash, EntityHostileSwim, EntityHuskAmbient,
            EntityHuskDeath, EntityHuskHurt, EntityHuskStep, EntityIllusionIllagerAmbient, EntityIllusionIllagerCastSpell, EntityIllusionIllagerDeath,
            EntityIllusionIllagerHurt, EntityIllusionIllagerMirrorMove, EntityIllusionIllagerPrepareBlindness, EntityIllusionIllagerPrepareMirror,
            EntityIrongolemAttack, EntityIrongolemDeath, EntityIrongolemHurt, EntityIrongolemStep, EntityItemBreak, EntityItemPickup, EntityItemframeAddItem,
            EntityItemframeBreak, EntityItemframePlace, EntityItemframeRemoveItem, EntityItemframeRotateItem, EntityLeashknotBreak, EntityLeashknotPlace,
            EntityLightningImpact, EntityLightningThunder, EntityLingeringpotionThrow, EntityLlamaAmbient, EntityLlamaAngry, EntityLlamaChest, EntityLlamaDeath,
            EntityLlamaEat, EntityLlamaHurt, EntityLlamaSpit, EntityLlamaStep, EntityLlamaSwag, EntityMagmacubeDeath, EntityMagmacubeHurt, EntityMagmacubeJump,
            EntityMagmacubeSquish, EntityMinecartInside, EntityMinecartRiding, EntityMooshroomShear, EntityMuleAmbient, EntityMuleChest, EntityMuleDeath,
            EntityMuleHurt, EntityPaintingBreak, EntityPaintingPlace, EntityParrotAmbient, EntityParrotDeath, EntityParrotEat, EntityParrotFly,
            EntityParrotHurt, EntityParrotImitateBlaze, EntityParrotImitateCreeper, EntityParrotImitateElderGuardian, EntityParrotImitateEnderdragon,
            EntityParrotImitateEnderman, EntityParrotImitateEndermite, EntityParrotImitateEvocationIllager, EntityParrotImitateGhast, EntityParrotImitateHusk,
            EntityParrotImitateIllusionIllager, EntityParrotImitateMagmacube, EntityParrotImitatePolarBear, EntityParrotImitateShulker,
            EntityParrotImitateSilverfish, EntityParrotImitateSkeleton, EntityParrotImitateSlime, EntityParrotImitateSpider, EntityParrotImitateStray,
            EntityParrotImitateVex, EntityParrotImitateVindicationIllager, EntityParrotImitateWitch, EntityParrotImitateWither,
            EntityParrotImitateWitherSkeleton, EntityParrotImitateWolf, EntityParrotImitateZombie, EntityParrotImitateZombiePigman,
            EntityParrotImitateZombieVillager, EntityParrotStep, EntityPigAmbient, EntityPigDeath, EntityPigHurt, EntityPigSaddle, EntityPigStep,
            EntityPlayerAttackCrit, EntityPlayerAttackKnockback, EntityPlayerAttackNodamage, EntityPlayerAttackStrong, EntityPlayerAttackSweep,
            EntityPlayerAttackWeak, EntityPlayerBigFall, EntityPlayerBreath, EntityPlayerBurp, EntityPlayerDeath, EntityPlayerHurt, EntityPlayerHurtDrown,
            EntityPlayerHurtonFire, EntityPlayerLevelup, EntityPlayerSmallFall, EntityPlayerSplash, EntityPlayerSwim, EntityPolarBearAmbient,
            EntityPolarBearBabyAmbient, EntityPolarBearDeath, EntityPolarBearHurt, EntityPolarBearStep, EntityPolarBearWarning, EntityRabbitAmbient,
            EntityRabbitAttack, EntityRabbitDeath, EntityRabbitHurt, EntityRabbitJump, EntitySheepAmbient, EntitySheepDeath, EntitySheepHurt, EntitySheepShear,
            EntitySheepStep, EntityShulkerAmbient, EntityShulkerClose, EntityShulkerDeath, EntityShulkerHurt, EntityShulkerHurtClosed, EntityShulkerOpen,
            EntityShulkerShoot, EntityShulkerTeleport, EntityShulkerBulletHit, EntityShulkerBulletHurt, EntitySilverfishAmbient, EntitySilverfishDeath,
            EntitySilverfishHurt, EntitySilverfishStep, EntitySkeletonAmbient, EntitySkeletonDeath, EntitySkeletonHurt, EntitySkeletonShoot, EntitySkeletonStep,
            EntitySkeletonHorseAmbient, EntitySkeletonHorseDeath, EntitySkeletonHorseHurt, EntitySlimeAttack, EntitySlimeDeath, EntitySlimeHurt,
            EntitySlimeJump, EntitySlimeSquish, EntitySmallMagmacubeDeath, EntitySmallMagmacubeHurt, EntitySmallMagmacubeSquish, EntitySmallSlimeDeath,
            EntitySmallSlimeHurt, EntitySmallSlimeJump, EntitySmallSlimeSquish, EntitySnowballThrow, EntitySnowmanAmbient, EntitySnowmanDeath,
            EntitySnowmanHurt, EntitySnowmanShoot, EntitySpiderAmbient, EntitySpiderDeath, EntitySpiderHurt, EntitySpiderStep, EntitySplashPotionBreak,
            EntitySplashPotionThrow, EntitySquidAmbient, EntitySquidDeath, EntitySquidHurt, EntityStrayAmbient, EntityStrayDeath, EntityStrayHurt,
            EntityStrayStep, EntityTntPrimed, EntityVexAmbient, EntityVexCharge, EntityVexDeath, EntityVexHurt, EntityVillagerAmbient, EntityVillagerDeath,
            EntityVillagerHurt, EntityVillagerNo, EntityVillagerTrading, EntityVillagerYes, EntityVindicationIllagerAmbient, EntityVindicationIllagerDeath,
            EntityVindicationIllagerHurt, EntityWitchAmbient, EntityWitchDeath, EntityWitchDrink, EntityWitchHurt, EntityWitchThrow, EntityWitherAmbient,
            EntityWitherBreakBlock, EntityWitherDeath, EntityWitherHurt, EntityWitherShoot, EntityWitherSpawn, EntityWitherSkeletonAmbient,
            EntityWitherSkeletonDeath, EntityWitherSkeletonHurt, EntityWitherSkeletonStep, EntityWolfAmbient, EntityWolfDeath, EntityWolfGrowl, EntityWolfHowl,
            EntityWolfHurt, EntityWolfPant, EntityWolfShake, EntityWolfStep, EntityWolfWhine, EntityZombieAmbient, EntityZombieAttackDoorWood,
            EntityZombieAttackIronDoor, EntityZombieBreakDoorWood, EntityZombieDeath, EntityZombieHurt, EntityZombieInfect, EntityZombieStep,
            EntityZombieHorseAmbient, EntityZombieHorseDeath, EntityZombieHorseHurt, EntityZombiePigAmbient, EntityZombiePigAngry, EntityZombiePigDeath,
            EntityZombiePigHurt, EntityZombieVillagerAmbient, EntityZombieVillagerConverted, EntityZombieVillagerCure, EntityZombieVillagerDeath,
            EntityZombieVillagerHurt, EntityZombieVillagerStep, ItemArmorEquipChain, ItemArmorEquipDiamond, ItemArmorEquipElytra, ItemArmorEquipGeneric,
            ItemArmorEquipGold, ItemArmorEquipIron, ItemArmorEquipLeather, ItemBottleEmpty, ItemBottleFill, ItemBottleFillDragonbreath, ItemBucketEmpty,
            ItemBucketEmptyLava, ItemBucketFill, ItemBucketFillLava, ItemChorusFruitTeleport, ItemElytraFlying, ItemFirechargeUse, ItemFlintandsteelUse,
            ItemHoeTill, ItemShieldBlock, ItemShieldBreak, ItemShovelFlatten, ItemTotemUse, MusicCreative, MusicCredits, MusicDragon, MusicEnd, MusicGame,
            MusicMenu, MusicNether, Record11, Record13, RecordBlocks, RecordCat, RecordChirp, RecordFar, RecordMall, RecordMellohi, RecordStal, RecordStrad,
            RecordWait, RecordWard, UiButtonClick, UiToastChallengeComplete, UiToastIn, UiToastOut, WeatherRain, WeatherRainAbove,
        };

        private static readonly Dictionary<int, Sound> FromId;
        private static readonly Dictionary<string, Sound> FromName;

        static Sound()
        {
            FromId = Values.ToDictionary(e => e.Id);
            FromName = Values.ToDictionary(e => e.Name);
        }

        /// <summary>
        /// Gets Sound from Id. Returns it, or null if there is no Sound with given Id.
        /// </summary>
        public static Sound GetFromId(int id) => FromId.TryGetValue(id, out Sound value) ? value : null;
        
        /// <summary>
        /// Gets Sound from name. Returns it, or null if there is no Sound with given name. 
        /// </summary>
        public static Sound GetFromName(string name) => FromName.TryGetValue(name, out Sound value) ? value : null;
    }
}
