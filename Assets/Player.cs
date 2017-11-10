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

	public Player(int seed, PlayerTypes types, int startingWealth, int variance){
		id = seed;
		type = types;
		points = startingWealth;
		cryptocurrency = startingWealth / 2;
		refUser = null;
		invst = false;
		varianceMeter = variance;
	}
	public Player(int seed, PlayerTypes types, int startingWealth, int variance, Player referrer, bool invested = false){
		id = seed;
		type = types;
		points = startingWealth;
		cryptocurrency = startingWealth / 2;
		refUser = referrer;
		invst = invested;
		varianceMeter = variance;
	}
	public int GetValue(){
		return points;
	}

	public bool Win(Game game){
		
		return true;
	}
}