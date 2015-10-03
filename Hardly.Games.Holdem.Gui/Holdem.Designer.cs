﻿namespace Hardly.Games.Holdem.Gui {
    partial class Holdem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.aNumberPlayers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.aNumberBigBlind = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.aButtonStartGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aLabelPlayerHand = new System.Windows.Forms.Label();
            this.aLabelCurrentPlayer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aButtonCheck = new System.Windows.Forms.Button();
            this.aButtonBet = new System.Windows.Forms.Button();
            this.aNumberBetOrRaiseAmount = new System.Windows.Forms.NumericUpDown();
            this.aButtonRaise = new System.Windows.Forms.Button();
            this.aButtonCall = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.aLabelCallAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aLabelBoardCards = new System.Windows.Forms.Label();
            this.aButtonFold = new System.Windows.Forms.Button();
            this.aTimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aLabelWinners = new System.Windows.Forms.Label();
            this.aLabelLosers = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aLabelPot = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aLabelAccountBalance = new System.Windows.Forms.Label();
            this.aNumberBalancePlayerId = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.aLabelViewAccountBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBigBlind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBetOrRaiseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBalancePlayerId)).BeginInit();
            this.SuspendLayout();
            // 
            // aNumberPlayers
            // 
            this.aNumberPlayers.Location = new System.Drawing.Point(114, 10);
            this.aNumberPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.aNumberPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aNumberPlayers.Name = "aNumberPlayers";
            this.aNumberPlayers.Size = new System.Drawing.Size(120, 20);
            this.aNumberPlayers.TabIndex = 0;
            this.aNumberPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of players:";
            // 
            // aNumberBigBlind
            // 
            this.aNumberBigBlind.Location = new System.Drawing.Point(114, 36);
            this.aNumberBigBlind.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.aNumberBigBlind.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.aNumberBigBlind.Name = "aNumberBigBlind";
            this.aNumberBigBlind.Size = new System.Drawing.Size(120, 20);
            this.aNumberBigBlind.TabIndex = 2;
            this.aNumberBigBlind.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Big blind:";
            // 
            // aButtonStartGame
            // 
            this.aButtonStartGame.Location = new System.Drawing.Point(159, 62);
            this.aButtonStartGame.Name = "aButtonStartGame";
            this.aButtonStartGame.Size = new System.Drawing.Size(75, 23);
            this.aButtonStartGame.TabIndex = 4;
            this.aButtonStartGame.Text = "Start game";
            this.aButtonStartGame.UseVisualStyleBackColor = true;
            this.aButtonStartGame.Click += new System.EventHandler(this.aButtonStartGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current player:";
            // 
            // aLabelPlayerHand
            // 
            this.aLabelPlayerHand.AutoSize = true;
            this.aLabelPlayerHand.Location = new System.Drawing.Point(95, 162);
            this.aLabelPlayerHand.Name = "aLabelPlayerHand";
            this.aLabelPlayerHand.Size = new System.Drawing.Size(44, 13);
            this.aLabelPlayerHand.TabIndex = 8;
            this.aLabelPlayerHand.Text = "[Ah][2d]";
            // 
            // aLabelCurrentPlayer
            // 
            this.aLabelCurrentPlayer.AutoSize = true;
            this.aLabelCurrentPlayer.Location = new System.Drawing.Point(95, 143);
            this.aLabelCurrentPlayer.Name = "aLabelCurrentPlayer";
            this.aLabelCurrentPlayer.Size = new System.Drawing.Size(13, 13);
            this.aLabelCurrentPlayer.TabIndex = 9;
            this.aLabelCurrentPlayer.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Player hand:";
            // 
            // aButtonCheck
            // 
            this.aButtonCheck.Location = new System.Drawing.Point(25, 189);
            this.aButtonCheck.Name = "aButtonCheck";
            this.aButtonCheck.Size = new System.Drawing.Size(75, 23);
            this.aButtonCheck.TabIndex = 11;
            this.aButtonCheck.Text = "Check";
            this.aButtonCheck.UseVisualStyleBackColor = true;
            this.aButtonCheck.Click += new System.EventHandler(this.aButtonCheck_Click);
            // 
            // aButtonBet
            // 
            this.aButtonBet.Location = new System.Drawing.Point(49, 273);
            this.aButtonBet.Name = "aButtonBet";
            this.aButtonBet.Size = new System.Drawing.Size(75, 23);
            this.aButtonBet.TabIndex = 12;
            this.aButtonBet.Text = "Bet";
            this.aButtonBet.UseVisualStyleBackColor = true;
            this.aButtonBet.Click += new System.EventHandler(this.aButtonBet_Click);
            // 
            // aNumberBetOrRaiseAmount
            // 
            this.aNumberBetOrRaiseAmount.Location = new System.Drawing.Point(25, 247);
            this.aNumberBetOrRaiseAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.aNumberBetOrRaiseAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aNumberBetOrRaiseAmount.Name = "aNumberBetOrRaiseAmount";
            this.aNumberBetOrRaiseAmount.Size = new System.Drawing.Size(180, 20);
            this.aNumberBetOrRaiseAmount.TabIndex = 13;
            this.aNumberBetOrRaiseAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aButtonRaise
            // 
            this.aButtonRaise.Location = new System.Drawing.Point(130, 273);
            this.aButtonRaise.Name = "aButtonRaise";
            this.aButtonRaise.Size = new System.Drawing.Size(75, 23);
            this.aButtonRaise.TabIndex = 14;
            this.aButtonRaise.Text = "Raise";
            this.aButtonRaise.UseVisualStyleBackColor = true;
            this.aButtonRaise.Click += new System.EventHandler(this.aButtonRaise_Click);
            // 
            // aButtonCall
            // 
            this.aButtonCall.Location = new System.Drawing.Point(25, 218);
            this.aButtonCall.Name = "aButtonCall";
            this.aButtonCall.Size = new System.Drawing.Size(75, 23);
            this.aButtonCall.TabIndex = 15;
            this.aButtonCall.Text = "Call";
            this.aButtonCall.UseVisualStyleBackColor = true;
            this.aButtonCall.Click += new System.EventHandler(this.aButtonCall_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "for";
            // 
            // aLabelCallAmount
            // 
            this.aLabelCallAmount.AutoSize = true;
            this.aLabelCallAmount.Location = new System.Drawing.Point(132, 223);
            this.aLabelCallAmount.Name = "aLabelCallAmount";
            this.aLabelCallAmount.Size = new System.Drawing.Size(25, 13);
            this.aLabelCallAmount.TabIndex = 17;
            this.aLabelCallAmount.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "On the board:";
            // 
            // aLabelBoardCards
            // 
            this.aLabelBoardCards.AutoSize = true;
            this.aLabelBoardCards.Location = new System.Drawing.Point(49, 116);
            this.aLabelBoardCards.Name = "aLabelBoardCards";
            this.aLabelBoardCards.Size = new System.Drawing.Size(62, 13);
            this.aLabelBoardCards.TabIndex = 19;
            this.aLabelBoardCards.Text = "[Ah][2d][3c]";
            // 
            // aButtonFold
            // 
            this.aButtonFold.Location = new System.Drawing.Point(25, 302);
            this.aButtonFold.Name = "aButtonFold";
            this.aButtonFold.Size = new System.Drawing.Size(75, 23);
            this.aButtonFold.TabIndex = 20;
            this.aButtonFold.Text = "Fold";
            this.aButtonFold.UseVisualStyleBackColor = true;
            this.aButtonFold.Click += new System.EventHandler(this.aButtonFold_Click);
            // 
            // aTimerRefresh
            // 
            this.aTimerRefresh.Enabled = true;
            this.aTimerRefresh.Tick += new System.EventHandler(this.aTimerRefresh_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last game:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Winners:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Losers:";
            // 
            // aLabelWinners
            // 
            this.aLabelWinners.AutoSize = true;
            this.aLabelWinners.Location = new System.Drawing.Point(70, 374);
            this.aLabelWinners.Name = "aLabelWinners";
            this.aLabelWinners.Size = new System.Drawing.Size(65, 13);
            this.aLabelWinners.TabIndex = 24;
            this.aLabelWinners.Text = "HardlySober";
            // 
            // aLabelLosers
            // 
            this.aLabelLosers.AutoSize = true;
            this.aLabelLosers.Location = new System.Drawing.Point(70, 391);
            this.aLabelLosers.Name = "aLabelLosers";
            this.aLabelLosers.Size = new System.Drawing.Size(65, 13);
            this.aLabelLosers.TabIndex = 25;
            this.aLabelLosers.Text = "HardlySober";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pot:";
            // 
            // aLabelPot
            // 
            this.aLabelPot.AutoSize = true;
            this.aLabelPot.Location = new System.Drawing.Point(44, 67);
            this.aLabelPot.Name = "aLabelPot";
            this.aLabelPot.Size = new System.Drawing.Size(13, 13);
            this.aLabelPot.TabIndex = 27;
            this.aLabelPot.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Your account balance:";
            // 
            // aLabelAccountBalance
            // 
            this.aLabelAccountBalance.AutoSize = true;
            this.aLabelAccountBalance.Location = new System.Drawing.Point(127, 328);
            this.aLabelAccountBalance.Name = "aLabelAccountBalance";
            this.aLabelAccountBalance.Size = new System.Drawing.Size(25, 13);
            this.aLabelAccountBalance.TabIndex = 29;
            this.aLabelAccountBalance.Text = "100";
            // 
            // aNumberBalancePlayerId
            // 
            this.aNumberBalancePlayerId.Location = new System.Drawing.Point(303, 143);
            this.aNumberBalancePlayerId.Name = "aNumberBalancePlayerId";
            this.aNumberBalancePlayerId.Size = new System.Drawing.Size(120, 20);
            this.aNumberBalancePlayerId.TabIndex = 30;
            this.aNumberBalancePlayerId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "View balance for:";
            // 
            // aLabelViewAccountBalance
            // 
            this.aLabelViewAccountBalance.AutoSize = true;
            this.aLabelViewAccountBalance.Location = new System.Drawing.Point(315, 166);
            this.aLabelViewAccountBalance.Name = "aLabelViewAccountBalance";
            this.aLabelViewAccountBalance.Size = new System.Drawing.Size(13, 13);
            this.aLabelViewAccountBalance.TabIndex = 32;
            this.aLabelViewAccountBalance.Text = "0";
            // 
            // Holdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 428);
            this.Controls.Add(this.aLabelViewAccountBalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.aNumberBalancePlayerId);
            this.Controls.Add(this.aLabelAccountBalance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aLabelPot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aLabelLosers);
            this.Controls.Add(this.aLabelWinners);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aButtonFold);
            this.Controls.Add(this.aLabelBoardCards);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aLabelCallAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aButtonCall);
            this.Controls.Add(this.aButtonRaise);
            this.Controls.Add(this.aNumberBetOrRaiseAmount);
            this.Controls.Add(this.aButtonBet);
            this.Controls.Add(this.aButtonCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aLabelCurrentPlayer);
            this.Controls.Add(this.aLabelPlayerHand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aButtonStartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aNumberBigBlind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aNumberPlayers);
            this.Name = "Holdem";
            this.Text = "Texas Holdem";
            ((System.ComponentModel.ISupportInitialize)(this.aNumberPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBigBlind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBetOrRaiseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumberBalancePlayerId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown aNumberPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown aNumberBigBlind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aButtonStartGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aLabelPlayerHand;
        private System.Windows.Forms.Label aLabelCurrentPlayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button aButtonCheck;
        private System.Windows.Forms.Button aButtonBet;
        private System.Windows.Forms.NumericUpDown aNumberBetOrRaiseAmount;
        private System.Windows.Forms.Button aButtonRaise;
        private System.Windows.Forms.Button aButtonCall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label aLabelCallAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label aLabelBoardCards;
        private System.Windows.Forms.Button aButtonFold;
        private System.Windows.Forms.Timer aTimerRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label aLabelWinners;
        private System.Windows.Forms.Label aLabelLosers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label aLabelPot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label aLabelAccountBalance;
        private System.Windows.Forms.NumericUpDown aNumberBalancePlayerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label aLabelViewAccountBalance;
    }
}

