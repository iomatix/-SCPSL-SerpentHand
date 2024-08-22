namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Spawn;
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Inventory;
    using global::Plugin.SerpentHand.RoleBehaviour;
    using global::Plugin.SerpentHand.Types;
    using PlayerRoles;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleCommander : CustomRole<SerpentHandRoleCommanderBehaviour>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandCommander;

        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent`s Commander";

        /// <inheritdoc />
        public override bool IsTeamUnit { get; set; } = true;

        /// <inheritdoc />
        public override RoleTypeId Role { get; set; } = RoleTypeId.ClassD;

        /// <inheritdoc />
        public override RoleTypeId AssignFromRole { get; set; } = RoleTypeId.ClassD;

        /// <inheritdoc />
        public override int Probability { get; set; } = 100;

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 1;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent`s Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.\n" +
            "Serpent’s Commander is an elite operative specializing in the protection and retrieval of anomalous entities using advanced and anomalous technology. The Commander leads the operation and his subordinates. He possesses the extraordinary ability to vanish, allowing him to dodge bullets with a certain probability for a short duration after reappearing.";

        /// <inheritdoc />
        public override bool IsScp { get; set; } = false;

        public override RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = true,
            UniqueRole = RoleTypeId.ClassD,
            SpawnReason = RoleChangeReason.Respawn,
            SpawnFlags = RoleSpawnFlags.All,
            SpawnProperties =
            {
                StaticSpawnPoints =
                {
                    
                },
                DynamicSpawnPoints =
                {
                    new DynamicSpawnPoint { Location = SpawnLocationType.InsideServersBottom, Chance = 0.5f },

                },
                RoleSpawnPoints =
                {
                    new RoleSpawnPoint { Role = RoleTypeId.ChaosRifleman, Chance = 0.5f },
                },
            },

            Health = 135,
            MaxHealth = 135,
            Scale = 1.01f,
            CustomInfo = "Serpent`s Hand Commander\nLeads the SCP rescue mission",

            SpawnedText = new TextDisplay("You`ve been spawned as Serpent`s Hand Commander.\nLead your troops and rescue the SCPs.", 10, channel: TextChannelType.Broadcast),

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

        public InventoryManager InitialInventory { get; set; } = new InventoryManager(
        new List<ItemType> {
                ItemType.ArmorCombat,
                ItemType.GunCOM18,
                ItemType.GunFRMG0,
                ItemType.SCP500,
                ItemType.Adrenaline,
                ItemType.KeycardChaosInsurgency,
        },
        new List<object> { },
        new Dictionary<AmmoType, ushort> {
                { AmmoType.Nato556, 164 },
                { AmmoType.Nato9, 48 },
        },
        new Dictionary<uint, ushort> { }
        );
    }
}