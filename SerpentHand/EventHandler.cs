// -----------------------------------------------------------------------
// <copyright file="EventHandler.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Plugin.EventHandlers
{
    using System.Collections.Generic;
    using Exiled.API.Features;
    using Exiled.Events.EventArgs.Player;
    using MEC;

    /// <summary>
    /// Main Event Handler
    /// </summary>
    public class EventHandler
    {

        private readonly Plugin _plugin;

        public EventHandler(Plugin plugin) => _plugin = plugin;

        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();

        /// <summary>
        /// Triggers on the beginning of the each round.
        /// </summary>
        public void OnRoundStarted()
        {
           //if (UnityEngine.Random.Range(0, 100) <= _plugin.Config.Spawnchance)
            {
                //_plugin.Methods.Init();
                //Coroutines.Add(Timing.RunCoroutine(_plugin.Methods.StartLockdownRoutine()));

            }
        }


        /// <summary>
        /// Triggers on the beginning of the each round during waiting screen.
        /// </summary>
        public void OnWaitingForPlayers()
        {
            //_plugin.Methods.Clean();
            foreach (CoroutineHandle handle in Coroutines) Timing.KillCoroutines(handle);
            Coroutines.Clear();

        }

        /// <summary>
        /// Triggers on the end of the each round.
        /// </summary>
        public void OnRoundEnded()
        {
            foreach (CoroutineHandle handle in Coroutines) Timing.KillCoroutines(handle);
            Coroutines.Clear();
        }

        private void OnVerified(VerifiedEventArgs ev) => Log.Info($"{ev.Player} has joined the server!");
    }
}