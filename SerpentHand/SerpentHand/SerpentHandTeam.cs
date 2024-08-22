namespace SerpentHand.SerpentHand
{
    using System.Collections.Generic;
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using PlayerRoles;
    using Plugin.SerpentHand.Types;
    using Respawning;

    /// <inheritdoc />
    [ModuleIdentifier]
    internal class SerpentHandTeam : CustomTeam

    {
        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent`s Hand";

        /// <inheritdoc />
        public override uint Id { get; set; } = CustomTeamTypes.SerpentHand;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public virtual string DisplayName { get; set; } = "Serpent`s Hand";

        /// <inheritdoc />
        public virtual string DisplayColor { get; set; } = "magenta";

        /// <inheritdoc />
        public virtual int Size { get; set; } = 7;

        /// <inheritdoc />
        public virtual IEnumerable<uint> Units { get; set; } = new uint[] {
            CustomRoleTypes.SerpentHandCommander, };

        /// <inheritdoc />
        public virtual int Probability { get; set; } = 100;

        /// <inheritdoc />
        public virtual SpawnableTeamType[] SpawnableFromTeams { get; set; } = {
            SpawnableTeamType.None,
            SpawnableTeamType.NineTailedFox,
            SpawnableTeamType.ChaosInsurgency,
        };

        /// <inheritdoc />
        public virtual bool UseTickets { get; set; } = true;

        /// <inheritdoc />
        public virtual uint Tickets { get; set; } = 13;

        /// <inheritdoc />
        public virtual RoleTypeId RequiredRoleToSpawn { get; set; } = RoleTypeId.Scientist;

        /// <inheritdoc />
        public virtual Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive };

    }
}