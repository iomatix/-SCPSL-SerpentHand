namespace SerpentHand.Roles
{
    using Exiled.CustomModules.API.Features;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using PlayerRoles;
    using SerpentHand.Behaviours;
    using SerpentHand.Types;
    using System;

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
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override RoleTypeId Role { get; set; } = RoleTypeId.ChaosConscript;

        /// <inheritdoc />
        public override int Probability { get; set; } = 100;

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        public override RoleTypeId AssignFromRole { get; set; } = RoleTypeId.None;

        /// <inheritdoc />
        public override int MaxInstances { get; set; } = 1;

        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent`s Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.\n" +
            "Serpent’s Commander is an elite operative specializing in the protection and retrieval of anomalous entities using advanced and anomalous technology. The Commander leads the operation and his subordinates. He possesses the extraordinary ability to vanish, allowing him to dodge bullets with a certain probability for a short duration after reappearing.";

        /// <inheritdoc />
        public override bool IsScp { get; set; } = false;

    }
}