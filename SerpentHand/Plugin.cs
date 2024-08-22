// -----------------------------------------------------------------------
// <copyright file="Example.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace SerpentHand
{
    using System;
    using Exiled.API.Features;
    using Exiled.Events;
    using MEC;

    using Server = Exiled.Events.Handlers.Server;

    public class Plugin : Plugin<Config, Translation>
    {
        public static Plugin Instance { get; private set; }
        public override string Author { get; } = "iomatix";

        public override string Name { get; } = "SerpentHand";

        public override string Prefix => "SerpentHand";

        public override Version Version => new Version(0, 1, 0);

        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        //internal Methods Methods { get; private set; }
        internal EventHandlers EventHandlers { get; private set; }


        /// <inheritdoc/>
        public override void OnEnabled()
        {
            Instance = this;
            EventHandlers = new EventHandlers(this);
            //Methods = new Methods(this);

            //CustomRole.EnableAll();
            //CustomTeam.EnableAll();

            RegisterEvents();
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            foreach (CoroutineHandle handle in EventHandlers.Coroutines) Timing.KillCoroutines(handle);
            EventHandlers.Coroutines.Clear();
            EventHandlers = null;

            UnRegisterEvents();
            base.OnDisabled();
        }

        /// <summary>
        /// Registers events to the event handler.
        /// </summary>
        private void RegisterEvents()
        {
            Server.WaitingForPlayers += EventHandlers.OnWaitingForPlayers;
        }

        /// <summary>
        /// Unregisters events to the event handler.
        /// </summary>
        private void UnRegisterEvents()
        {
            Server.WaitingForPlayers -= EventHandlers.OnWaitingForPlayers;
        }
    }
}