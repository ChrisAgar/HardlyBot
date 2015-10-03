﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardly.Games.Holdem.Gui {
    public partial class Holdem : Form {
        TexasHoldem<int> game = new TexasHoldem<int>();
        PlayerPointManager[] pointManagers;

        public Holdem() {
            InitializeComponent();

            pointManagers = new PlayerPointManager[100];
            for(int i = 0; i < pointManagers.Length; i++) {
                pointManagers[i] = new PlayerPointManager();
                pointManagers[i].TotalPointsInAccount = 100000;
            }
        }

        private void aButtonStartGame_Click(object sender, EventArgs e) {
            game.Reset();
            game.bigBlind = ((ulong)aNumberBigBlind.Value);

            for(int i = 0; i < aNumberPlayers.Value; i++) {
                game.Join(i, pointManagers[i]);
            }

            if(game.CanStart()) {
                game.StartGame();
            }
        }

        private void aButtonCheck_Click(object sender, EventArgs e) {
            game.Check();
        }

        private void aButtonCall_Click(object sender, EventArgs e) {
            game.Call();
        }

        private void aButtonBet_Click(object sender, EventArgs e) {
            game.Bet((ulong)aNumberBetOrRaiseAmount.Value);
        }

        private void aButtonRaise_Click(object sender, EventArgs e) {
            game.Raise((ulong)aNumberBetOrRaiseAmount.Value);
        }

        private void aButtonFold_Click(object sender, EventArgs e) {
            game.Fold();
        }

        private void aTimerRefresh_Tick(object sender, EventArgs e) {
            var player = game.currentPlayer;
            if(player != null) {
                aLabelCurrentPlayer.Text = player.idObject.ToString();
                aLabelPlayerHand.Text = player.hand.cards.ToString();
                aLabelBoardCards.Text = game.tableCards.ToString();
                aLabelAccountBalance.Text = pointManagers[player.idObject].Points.ToStringWithCommas();
            } else {
                aLabelCurrentPlayer.Text = "";
                aLabelPlayerHand.Text = "";
                aLabelBoardCards.Text = "";
                aLabelAccountBalance.Text = "";
            }

            string winners = null;
            if(game.lastGameWinners != null) {
                foreach(var winner in game.lastGameWinners) {
                    if(winners == null) {
                        winners = "";
                    } else {
                        winners += ", ";
                    }
                    winners += winner.Item1.idObject.ToString();
                }
            }
            aLabelWinners.Text = winners;

            string losers = null;
            //if(game.lastGameLosers != null) {
            //    foreach(var loser in game.lastGameLosers) {
            //        if(losers == null) {
            //            losers = "";
            //        } else {
            //            losers += ", ";
            //        }
            //        losers += loser.idObject.ToString();
            //    }
            //}
            aLabelLosers.Text = losers;

            aLabelPot.Text = game.GetTotalPot().ToString();
            aLabelCallAmount.Text = game.GetCallAmount().ToString();

            aLabelViewAccountBalance.Text = pointManagers[(int)aNumberBalancePlayerId.Value].Points.ToStringWithCommas();
        }
    }
}
