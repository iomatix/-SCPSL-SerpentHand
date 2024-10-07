namespace SerpentHand
{
    using System.Collections.Generic;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using PlayerRoles;
    using Respawning;
    using SerpentHand.Types;

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
        public override string DisplayName { get; set; } = "Serpent`s Hand";

        /// <inheritdoc />
        public override string DisplayColor { get; set; } = "magenta";

        /// <inheritdoc />
        public override int Size { get; set; } = 7;

        /// <inheritdoc />
        public override IEnumerable<uint> Units { get; set; } = new uint[] {
            CustomRoleTypes.SerpentHandCommander, };

        /// <inheritdoc />
        public override int Probability { get; set; } = 100;




        /// <inheritdoc />
        public override SpawnableTeamType[] SpawnableFromTeams { get; set; } = {
            SpawnableTeamType.None,
            SpawnableTeamType.NineTailedFox,
            SpawnableTeamType.ChaosInsurgency,
        };

        /// <inheritdoc />
        public override bool UseTickets { get; set; } = true;

        /// <inheritdoc />
        public override uint Tickets { get; set; } = 13;

        /// <inheritdoc />
        public override RoleTypeId RequiredRoleToSpawn { get; set; } = RoleTypeId.None;

        /// <inheritdoc />
        public override Team RequiredTeamToSpawn { get; set; } = Team.Dead;

        /// <inheritdoc />
        public override uint RequiredCustomTeamToSpawn { get; set; }

        /// <inheritdoc />
        public override uint RequiredCustomRoleToSpawn { get; set; }

        

        /// <inheritdoc />
        public override Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive };

    }
}