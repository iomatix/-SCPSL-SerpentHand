namespace Exiled.Example.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using PlayerRoles;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandRole : CustomRole<SerpentHandBehaviour>
    {
        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent Hand";

        /// <inheritdoc />
        public override uint Id { get; set; } = CustomRoleType.SerpentHand;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Description { get; set; } = "Serpent Hand";

        /// <inheritdoc />
        public override RoleTypeId Role { get; set; } = RoleTypeId.CustomRole;

        /// <inheritdoc />
        public override int Probability { get; set; } = 100;

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 5;

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs };

        /// <inheritdoc />
        public override RoleTypeId AssignFromRole { get; set; } = RoleTypeId.None;

        /// <inheritdoc />
        public override bool IsScp { get; set; } = false;

        /// <inheritdoc />
        public override RoleSettings Settings { get; set; } = new RoleSettings()
        {
            UseDefaultRoleOnly = true,
            UniqueRole = RoleTypeId.CustomRole,

            Health = 145,
            MaxHealth = 145,
            Scale = 0.90f,
            CustomInfo = "Serpent Hand",

            SpawnedText = new API.Features.TextDisplay("You've been spawned as Serpent Hand", 10, channel: TextChannelType.Broadcast),

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