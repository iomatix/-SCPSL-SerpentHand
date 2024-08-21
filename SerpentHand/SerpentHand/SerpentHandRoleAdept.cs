namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Inventory;
    using global::Plugin.SerpentHand.RoleBehaviour;
    using global::Plugin.SerpentHand.Types;
    using PlayerRoles;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleAdept : CustomRole<SerpentHandSHLeaderBehaviour>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandAdept;

        /// <inheritdoc />
        public override bool IsTeamUnit { get; set; } = true;

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 4;

        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent's Hand Adept";

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent's Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.";

        public RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = false,
            UniqueRole = RoleTypeId.CustomRole,

            Health = 125,
            MaxHealth = 125,
            Scale = 1.0f,
            CustomInfo = "Serpent's Hand Adept\nThe Adept participates in the SCP rescue mission",

            SpawnedText = new TextDisplay("You've been spawned as Serpent's Hand Adept.\nYour task is to rescue the SCPs.", 10, channel: TextChannelType.Broadcast),

            PreservePosition = false,

            PreserveInventory = true,

            CanActivateWarhead = true,
            CanUseIntercom = true,
            CanDropItems = true,
            CanUseElevators = true,
            CanUseVoiceChat = true,
            CanActivateWorkstations = true,
            CanPickupItems = true,
            CanEnterPocketDimension = true,
            CanSelectItems = true,

            CanBypassCheckpoints = false,
            CanActivateGenerators = true,
            CanPlaceBlood = true,
            CanBeHurtByScps = true,
            CanHurtScps = true,
            CanBeHandcuffed = true,

            DoesLookingAffectScp096 = true,
            DoesLookingAffectScp173 = true,
        };

        //public string ExampleConfigurableParam { get; set; } = 'example';

        public InventoryManager InitialInventory { get; set; } = new InventoryManager(
            new List<ItemType> {
                ItemType.ArmorCombat,
                ItemType.GunCOM18,
                ItemType.GunCrossvec,
                ItemType.Medkit,
                ItemType.Adrenaline,
                ItemType.KeycardChaosInsurgency,
            },
            // Todo Custom item, SCP coin which makes invisible
            new List<object> { },
            new Dictionary<AmmoType, ushort> {
                    { AmmoType.Nato556, 48 },
                    { AmmoType.Nato9, 164 },
            },
            new Dictionary<uint, ushort> { }
            );
    }
}