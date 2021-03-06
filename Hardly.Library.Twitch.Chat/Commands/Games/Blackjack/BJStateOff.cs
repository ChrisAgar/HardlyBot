﻿using System;

namespace Hardly.Library.Twitch {
	public class BJStateOff : GameState<TwitchBlackjack> {
		Timer timer;

		public BJStateOff(TwitchBlackjack controller) : base(controller) {
			timer = new Timer(TimeSpan.FromSeconds(30), AutoStart);
        }

        protected override void OpenState() {
            AddCommand(controller.room, "bj", BjCommand, "Starts a game of Blackjack", new[] { "blackjack" }, false, null, false);
            controller.game.Reset();
        }

        private void BjCommand(TwitchUser speaker, string additionalText) {
			controller.SetState(this, typeof(BJStateAcceptingPlayers));
		}

		private void AutoStart() {
			controller.SetState(this, typeof(BJStateAcceptingPlayers)); 
		}

        protected override void CloseState() {
            base.CloseState();
			timer?.Stop();
		}
	}
}
