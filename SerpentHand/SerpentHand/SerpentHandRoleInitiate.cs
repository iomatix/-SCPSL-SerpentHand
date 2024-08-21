namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Spawn;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Inventory;
    using global::Plugin.SerpentHand.RoleBehaviour;
    using global::Plugin.SerpentHand.Types;
    using PlayerRoles;
    using PlayerRoles.FirstPersonControl.Spawnpoints;
    using Respawning;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleInitiate : CustomRole<SerpentHandSHInitiateBehaviour>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandInitiate;

        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent`s Hand Initiate";

        /// <inheritdoc />
        public override bool IsTeamUnit { get; set; } = true;

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 3;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent`s Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.";


        public virtual RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = false,
            UniqueRole = RoleTypeId.CustomRole,

            Health = 100,
            MaxHealth = 100,
            Scale = 0.95f,
            CustomInfo = "Serpent`s Hand Initiate\nThe Initiate helps with the SCP rescue mission",

            SpawnedText = new TextDisplay("You've been spawned as Serpent`s Hand Initiate.\nHelp to rescue the SCPs.", 10, channel: TextChannelType.Broadcast),

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

            SpawnProperties = new Exiled.API.Features.Spawn.SpawnProperties()
            {
                Limit = 4,
                

            }
        };

        //public string ExampleConfigurableParam { get; set; } = 'example';

        public virtual InventoryManager InitialInventory { get; set; } = new InventoryManager(
            new List<ItemType> {
                ItemType.ArmorCombat,
                ItemType.GunCOM18,
                ItemType.GunShotgun,
                ItemType.Medkit ,
                ItemType.KeycardChaosInsurgency,
            },
            new List<object> { },
            new Dictionary<AmmoType, ushort> {
                { AmmoType.Ammo12Gauge, 48 },
                { AmmoType.Nato9, 32 },
            },
            new Dictionary<uint, ushort> { }
            );
    }
}