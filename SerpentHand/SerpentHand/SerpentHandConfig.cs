﻿namespace Exiled.Example.SerpentHandRole
{
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;
    using Exiled.CustomModules.API.Features.Generic;

    /// <inheritdoc />
    [ModuleIdentifier]
    public class SerpentHandConfig : ModulePointer<CustomRole>
    {
        /// <inheritdoc />
        //public override uint Id { get; set; } = CustomRoleType.;
        public override uint Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}