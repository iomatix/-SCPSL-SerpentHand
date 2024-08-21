// -----------------------------------------------------------------------
// <copyright file="Example.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Plugin
{
    using System;
    using Exiled.API.Features;
    using Exiled.API.Enums;

    /// <summary>
    /// The example plugin.
    /// </summary>
    public class Plugin : Plugin<Configuration.Config, PluginTranslation.Translation>
    {
        /// <summary>
        /// Gets the only existing instance of this plugin.
        /// </summary>
        public static Plugin Instance { get; private set; }

        /// <inheritdoc/>
        public override string Name { get; } = "SerpentHand";

        /// <inheritdoc/>
        public override string Prefix => "SerpentHand";

        /// <inheritdoc/>
        public override Version Version => new Version(0, 1, 0);

        /// <inheritdoc/>
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        /// <inheritdoc/>
        public override string Author { get; } = "iomatix";

        /// <inheritdoc/>

        public override PluginPriority Priority => PluginPriority.Medium;

        /// <summary>
        /// Gets the current instance of the event handler.
        /// </summary>
        public EventHandlers.EventHandler EventHandlers { get; private set; }

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            // Set the instance to the current one
            Instance = this;

            // Create new instance of the event handler
            EventHandlers = new EventHandlers.EventHandler(this);

            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            // Finishes the event handler
            EventHandlers = null;

            base.OnDisabled();
        }

        /// <summary>
        /// Registers events to the event handler.
        /// </summary>
        private void RegisterEvents()
        {
            //Server = new Server(this);
            //Methods = new Methods(this);
            //Exiled.Events.Handlers.Server.RoundStarted += Server.OnRoundStarted;
            //Exiled.Events.Handlers.Server.RoundEnded += Server.OnRoundEnded;
            //Exiled.Events.Handlers.Server.WaitingForPlayers += Server.OnWaitingForPlayers;
        }

        /// <summary>
        /// Unregisters events to the event handler.
        /// </summary>
        private void UnRegisterEvents()
        {
            //Exiled.Events.Handlers.Server.RoundStarted -= Server.OnRoundStarted;
            //Exiled.Events.Handlers.Server.RoundEnded -= Server.OnRoundEnded;
            //Exiled.Events.Handlers.Server.WaitingForPlayers -= Server.OnWaitingForPlayers;

            //Server = null;
            //Methods = null;
        }

    }
}