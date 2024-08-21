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
        public override int MaxInstances { get; set; } = 3;

        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent's Hand Initiate";
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;
        /// <inheritdoc />
        public override string Description { get; set; } = "The Serpent's Hand is a small but formidable organization that embraces the use and existence of paranormal items, particularly humanoid and sapient SCP objects. They have been vocal in judging the containment and destruction of SCP items, especially those not seen as dangerous.";


    }
}