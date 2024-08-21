namespace Plugin.SerpentHand.Types
{
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features.CustomRoles;

    /// <summary>
    /// The custom role type.
    /// </summary>
    public class CustomRoleTypes : UUCustomRoleType
    {

        public static readonly CustomRoleTypes SerpentHandTemplate = new CustomRoleTypes();
        public static readonly CustomRoleTypes SerpentHandLeader = new CustomRoleTypes();
        public static readonly CustomRoleTypes SerpentHandAdept = new CustomRoleTypes();
        public static readonly CustomRoleTypes SerpentHandInitiate = new CustomRoleTypes();

    }
}