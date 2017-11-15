
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Game {
	public Lane[] lanes;
	private Player owner;
	public Player opponent;
	//public Game otherGame;
	public bool hasDouble;
	bool isStartingPlayer;

	int doubleTimeBoost;

	int roundsLeft;

	public Game(Player player, Player otherPlayer, bool startingPlayer) {
		owner = player;
		opponent = otherPlayer;
		isStartingPlayer = startingPlayer;
		roundsLeft = 4;
		doubleTimeBoost = 3;
		lanes = new Lane[3] { new Lane(roundsLeft), new Lane(roundsLeft), new Lane(roundsLeft) };

	}

	public Game(Player player, Player otherPlayer, bool startingPlayer, int roundNum, int doubleTimeAmount) {
		owner = player;
		opponent = otherPlayer;
		isStartingPlayer = startingPlayer;

		roundsLeft = roundNum;
		doubleTimeBoost = doubleTimeAmount;

		lanes = new Lane[3] { new Lane(), new Lane(), new Lane() };
	}

	public bool CanDouble(){
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

	public void Draw(Card[] c){
		for(int i = 0; i < 3; i++){
			lanes[i].AddCard(c[i]);
		}
	}
}

public class Lane{
	Card[] cards;
	//Card[] oCards;
	int value;

	public int maxCards;

	public Lane(){
		//oCards = new Card[1];
		maxCards = 4;
		cards = new Card[maxCards];

		value = 0;
	}

	public Lane(int roundsLeft) {
		//oCards = new Card[1];
		maxCards = roundsLeft;
		cards = new Card[maxCards];

		value = 0;
	}

	public int GetValue(){
		return value;
	}

	public void Add(int amt){
		value+= amt;
	}

	Card[] RestackCards(){
		Card[] temp = new Card[maxCards + 3];
		for(int i = 0; i < maxCards; i++){
			temp[i] = cards[i];
		}
		maxCards += 3;
		return temp;
	}

	public void AddCard(Card c){
		if (cards.Count(x => x != null) >= maxCards)
			cards = RestackCards();
		cards[cards.Count(x => x != null)] = c;

		Add(c.value);
	}
}