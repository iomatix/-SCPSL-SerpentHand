namespace SerpentHand
{
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;
    using SerpentHand.Types;

    /// <inheritdoc />
    [ModuleIdentifier]
    internal class SerpentHandTeamConfig : ModulePointer<CustomTeam>

    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomTeamTypes.SerpentHand;




    }
}