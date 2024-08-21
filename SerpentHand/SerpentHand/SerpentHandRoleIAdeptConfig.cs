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
    using Plugin.SerpentHand.Types;


    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleIAdeptConfig : ModulePointer<CustomRole>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandInitiate;


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