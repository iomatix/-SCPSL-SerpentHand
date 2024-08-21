namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using global::Plugin.SerpentHand.RoleBehaviour;
    using global::Plugin.SerpentHand.Types;
    using PlayerRoles;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRoleInitiate : CustomRole<SerpentHandSHLeaderBehaviour>
    {

        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleTypes.SerpentHandInitiate;
        /// <inheritdoc />
        public override bool IsTeamUnit { get; set; } = true;
        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 1;


        public override RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = true,
            UniqueRole = RoleTypeId.CustomRole,

            Health = 100,
            MaxHealth = 100,
            Scale = 0.95f,
            CustomInfo = "Serpent Hand Leader\nHelps with the SCP rescue mission",

            SpawnedText = new TextDisplay("You've been spawned as Serpent Hand Initiate.\nHelp to rescue the SCPs.", 10, channel: TextChannelType.Broadcast),

            PreservePosition = false,

            PreserveInventory = true,

            CanActivateWarhead = true,

            CanBypassCheckpoints = false,
            CanActivateGenerators = true,
            CanPlaceBlood = true,
            CanBeHurtByScps = true,
            CanHurtScps = true,
            CanBeHandcuffed = true,

            DoesLookingAffectScp096 = true,
            DoesLookingAffectScp173 = true,
        };
    }
}