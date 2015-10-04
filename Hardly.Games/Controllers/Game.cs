﻿using System.Collections.Generic;

namespace Hardly.Games {
    public abstract class Game {
    }

	public abstract class Game<PlayerIdType, PlayerGameType> : Game {
		public readonly uint maxPlayers;
		Dictionary<PlayerIdType, PlayerGameType> players = new Dictionary<PlayerIdType, PlayerGameType>();

		public Game(uint maxPlayers) {
			this.maxPlayers = maxPlayers;
		}

        public virtual bool CanStart() {
            return NumberOfPlayers() >= 1;
        }

        public bool Contains(PlayerIdType playerId) {
            return players.ContainsKey(playerId);
        }
        
        public abstract void EndGame();

        public PlayerGameType Get(PlayerIdType player) {
            PlayerGameType results;
            if(players.TryGetValue(player, out results)) {
                return results;
            }

            return (PlayerGameType)typeof(PlayerGameType).GetDefaultValue();
        }

        public bool IsEmpty() {
            return players.Count == 0;
        }

        public bool IsFull() {
			return players.Count >= maxPlayers;
		}

        public virtual bool Join(PlayerIdType playerId, PlayerGameType gameObject) {
            if(!IsFull()) {
                players.Add(playerId, gameObject);
                return true;
            }

            return false;
        }

        public virtual void LeaveGame(PlayerIdType playerId) {
            players.Remove(playerId);
        }

        public int NumberOfOpenSpots() {
            return (int)(maxPlayers - players.Count);
        }

        public int NumberOfPlayers() {
            return players.Count;
        }

        public Dictionary<PlayerIdType, PlayerGameType>.ValueCollection PlayerGameObjects {
            get {
                return players.Values;
            }
        }

        public virtual void Reset() {
            players.Clear();
        }

        public virtual bool StartGame() {
            return CanStart();
        }
    }
}
