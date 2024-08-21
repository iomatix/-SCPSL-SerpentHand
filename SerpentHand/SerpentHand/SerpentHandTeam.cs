namespace SerpentHand.SerpentHand
{

    using Exiled.API.Features.Attributes;
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using PlayerRoles;
    using Plugin.SerpentHand.Types;
    using Respawning;
    using System.Collections.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    internal class SerpentHandTeam : CustomTeam

    {
        /// <inheritdoc />
        public override string Name { get; set; } = "Serpent Hand";

        /// <inheritdoc />
        public override uint Id { get; set; } = CustomTeamType.SerpentHand;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Defines the maximum number of players that can populate the team at once.
        /// </summary>
        public virtual int Size { get; set; } = 7;

        /// <summary>
        /// Specifies the roles that form the team using custom enum.
        /// </summary>
        public virtual IEnumerable<uint> Units { get; set; } = new uint[] { 
            CustomRoleTypes.SerpentHandInitiate, 
            CustomRoleTypes.SerpentHandAdept, 
            CustomRoleTypes.SerpentHandLeader, };


        /// <summary>
        /// Indicates the likelihood of the team being included in the spawn queue.
        /// </summary>
        public virtual int Probability { get; set; } = 45;

        /// <summary>
        /// IContains the teams from which this team should be queued.
        /// </summary>
        public virtual SpawnableTeamType[] SpawnableFromTeams { get; set; } = {
            SpawnableTeamType.None, 
            SpawnableTeamType.ChaosInsurgency,
        };

        /// <summary>
        /// Determines whether tickets are used to regulate the team's spawn.
        /// </summary>
        public virtual bool UseTickets { get; set; } = true;

        /// <summary>
        /// Sets the initial number of tickets for the team.
        /// </summary>
        public virtual uint Tickets { get; set; } = 13;


        public virtual RoleTypeId RequiredRoleToSpawn { get; set; } = RoleTypeId.None;

        public virtual Team[] TeamsOwnership { get; set; } = { Team.SCPs, Team.OtherAlive };

        
    }
}
