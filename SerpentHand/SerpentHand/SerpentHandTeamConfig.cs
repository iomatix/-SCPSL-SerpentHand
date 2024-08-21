namespace Exiled.Example.SerpentHandRole
{
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;
    using Plugin.SerpentHand.Types;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandTeamConfig : ModulePointer<CustomRole>
    {
        /// <inheritdoc />
        public override uint Id { get; set; } = CustomTeamTypes.SerpentHand;
    }
}