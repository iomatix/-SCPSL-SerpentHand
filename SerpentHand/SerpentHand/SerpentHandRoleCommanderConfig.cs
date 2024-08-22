namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Spawn;
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;
    using Exiled.CustomModules.API.Features.Inventory;
    using global::Plugin.SerpentHand.Types;
    using PlayerRoles;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleCommanderConfig : ModulePointer<CustomRole>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandCommander;

        public RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = true,
            IsRoleDynamic = false,
            UniqueRole = RoleTypeId.Scientist,
            SpawnReason = RoleChangeReason.RemoteAdmin,
            SpawnFlags = RoleSpawnFlags.All,
            SpawnProperties =
            {
                StaticSpawnPoints =
                {

                },
                DynamicSpawnPoints =
                {
                    new DynamicSpawnPoint { Location = SpawnLocationType.InsideServersBottom, Chance = 1.0f },

                },
                RoleSpawnPoints =
                {
                    new RoleSpawnPoint { Role = RoleTypeId.ChaosRifleman, Chance = 1.0f },
                },
            },

            Health = 135,
            MaxHealth = 135,
            ArtificialHealth = 75,
            MaxArtificialHealth = 125,

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

        public InventoryManager Inventory { get; set; } = new InventoryManager(
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