namespace SerpentHand.Types
{
    using Exiled.CustomModules.API.Enums;
    using Exiled.CustomModules.API.Features.Attributes;
    using Exiled.CustomModules.API.Features.CustomRoles;

    /// <summary>
    /// The custom role type.
    /// </summary>
    [ModuleIdentifier]
    public class CustomRoleTypes : UUCustomRoleType
    {
        // Leader
        // TODO: Can vanish by using skill and go through doors (during this). Reappears after X time or on any action or on any damage.
        // TODO: Can dodge bullets with certain probability for x secs after reappeared
        public static readonly CustomRoleTypes SerpentHandCommander = new CustomRoleTypes();

        // Breach Front Line
        // TODO: Has best load out and best HP
        public static readonly CustomRoleTypes SerpentHandEnforcer = new CustomRoleTypes();
        // TODO: Breaching tools or skill (boom)
        public static readonly CustomRoleTypes SerpentHandBreaker = new CustomRoleTypes();


        // Stealth
        // TODO: Can vanish by using SCP coin
        public static readonly CustomRoleTypes SerpentHandPhantom = new CustomRoleTypes();
        // TODO: Can see the sound
        public static readonly CustomRoleTypes SerpentHandNavigator = new CustomRoleTypes();
    }
}