namespace SerpentHand.Configs
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Spawn;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;
    using Exiled.CustomModules.API.Features.Inventory;
    using PlayerRoles;
    using SerpentHand.Types;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleCommanderConfig : ModulePointer<CustomRole>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandCommander;

        public virtual RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = true,
            IsRoleDynamic = false,
            UniqueRole = RoleTypeId.CustomRole,
            SpawnReason = RoleChangeReason.Respawn,
            SpawnFlags = RoleSpawnFlags.All,
            SpawnProperties =
            {
                Limit = 1,
                StaticSpawnPoints =
                {

                },
                DynamicSpawnPoints =
                {
                    new DynamicSpawnPoint { Location = SpawnLocationType.InsideServersBottom, Chance = 100.0f },
                    new DynamicSpawnPoint { Location = SpawnLocationType.InsideSurfaceNuke, Chance = 100.0f },

                },
                RoleSpawnPoints =
                {
                    new RoleSpawnPoint { Role = RoleTypeId.ChaosRifleman, Chance = 100.0f },
                },
            },

            Health = 135,
            MaxHealth = 135,
            ArtificialHealth = 0,
            MaxArtificialHealth = 125,

            Scale = 1.01f,
            CustomInfo = "Serpent`s Hand Commander\nLeads the SCP rescue mission",

            SpawnedText = new TextDisplay("You`ve been spawned as Serpent`s Hand Commander.\nLead your troops and rescue the SCPs.", 12, channel: TextChannelType.Broadcast),

            PreservePosition = false,

            PreserveInventory = false,
            
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
        public virtual InventoryManager Inventory { get; set; } = new InventoryManager(
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