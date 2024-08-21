namespace Exiled.Example.SerpentHandRole
{
    using System.Collections.Generic;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomItems;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;
    using Exiled.CustomModules.API.Features.Inventory;
    using PlayerRoles;
    using Plugin.SerpentHand.RoleBehaviour;
    using Plugin.SerpentHand.Types;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleLeaderConfig : ModulePointer<CustomRole<SerpentHandSHLeaderBehaviour>>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandLeader;


        public RoleSettings Settings { get; set; } = new RoleSettings()
        {

            UseDefaultRoleOnly = false,
            UniqueRole = RoleTypeId.CustomRole,

            Health = 145,
            MaxHealth = 145,
            Scale = 1.04f,
            CustomInfo = "Serpent's Hand Leader\nHelps with the SCP rescue mission",


            SpawnedText = new TextDisplay("You've been spawned as Serpent's Hand Leader.\nLead your troops and rescue the SCPs.", 10, channel: TextChannelType.Broadcast),

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