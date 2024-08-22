// -----------------------------------------------------------------------
// <copyright file="EventHandler.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace SerpentHand
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using MEC;

    /// <summary>
    /// Main Event Handler
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin _plugin;
        public EventHandlers(Plugin plugin) => _plugin = plugin;

        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();

        /// <summary>
        /// Triggers on the beginning of the each round.
        /// </summary>
        public void OnRoundStart()
        {
            //_plugin.Methods.Init();
        }

        public void OnRoundEnded()
        {
            //_plugin.Methods.Disable();
        }

        public void OnWaitingForPlayers()
        {
            //_plugin.Methods.Disable();
        }



    }
}