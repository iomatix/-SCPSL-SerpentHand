namespace Plugin.SerpentHand.SerpentHandRole
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Spawn;
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features;
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
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive, };

        /// <inheritdoc />
        //public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;

        /// <inheritdoc />
        //public override RoleTypeId AssignFromRole { get; set; } = RoleTypeId.Scientist;

        /// <inheritdoc />
        //public override int Probability { get; set; } = 100;

        /// <inheritdoc />
        //public override int MaxInstances { get; set; } = 111;

        /// <inheritdoc />
        //public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent`s Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.\n" +
            "Serpent’s Commander is an elite operative specializing in the protection and retrieval of anomalous entities using advanced and anomalous technology. The Commander leads the operation and his subordinates. He possesses the extraordinary ability to vanish, allowing him to dodge bullets with a certain probability for a short duration after reappearing.";

        /// <inheritdoc />
        public override bool IsScp { get; set; } = false;



}