using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerTypes{
	passive,
	aggressive
}

public class Player {
	int id;
	PlayerTypes type;
	int points;
	int cryptocurrency;
	Player refUser;
	bool invst;
	int varianceMeter;

	Game currentGame;
	bool queuing;

	public Player(int seed, PlayerTypes types, int startingWealth, int variance){
		id = seed;
		type = types;
		points = startingWealth;
		cryptocurrency = startingWealth / 2;
		refUser = null;
		invst = false;
		varianceMeter = variance;

		currentGame = null;
		queuing = false;
	}
	public Player(int seed, PlayerTypes types, int startingWealth, int variance, Player referrer, bool invested = false){
		id = seed;
		type = types;
		points = startingWealth;
		cryptocurrency = startingWealth / 2;
		refUser = referrer;
		invst = invested;
		varianceMeter = variance;

		currentGame = null;
		queuing = false;
	}
	public int GetValue(){
		return points;
	}


	public bool Win(Game game){
		
		return true;
	}

	public void JoinQueue(){
		if(currentGame == null){
			MatchMaker.Join(this);
			queuing = true;
		}
	}

	public bool AcceptGame(Player opponent){
		if(currentGame == null && queuing == false){
			currentGame = new Game(this, opponent, false);
			queuing = false;
			return true;
		}
		return false;
	}

	public bool StartGame(Player opponent){
		if(opponent.AcceptGame(this) && queuing == true){
			currentGame = new Game(this, opponent, true);
			queuing = false;
			return true;
		}
		return false;
	}
}