using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {
	public Lane[] lanes;
	private Player owner;
	//public Player opponent;
	public Game otherGame;
	public bool hasDouble;
	bool isStartingPlayer;
	public Game(Player player/*Player otherPlayer*/, bool startingPlayer) {
		owner = player;
		lanes = new Lane[3]{new Lane(), new Lane(), new Lane()};
		//opponent = otherPlayer;
		isStartingPlayer = startingPlayer;
	}

	public bool canDouble(){
		if(hasDouble == true){
			int total = 0;
			for(int i = 0; i < 3; i++){
				total += lanes[i].GetValue();
			}
			if(total >= owner.GetValue()){
				return true;
			}
		}
		return false;
	}
}

public class Lane{
	Card[] cards;
	Card[] oCards;
	int value;
	int oValue;

	public Lane(){
		oCards = new Card[1];
		cards = new Card[5];

		value = 0;
		oValue = 0;
	}

	public int GetValue(){
		return value;
	}

	public void Add(int amt){
		value+= amt;
	}
}