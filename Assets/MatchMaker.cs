using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatchMaker {
	static Block[] queue;

	static int blocks;
	static int highBlockValue;

	static int blockStep;

	public static void Instantiate(int blockCount, int valueCeiling){
		blocks = blockCount;
		highBlockValue = valueCeiling;

		blockStep = highBlockValue / blocks;
	}


	public static void Tick(){
		//TICK TICK TICK IM A TICKING TIME BOMB
		
	}

	public static void Join(Player p){
		queue[Sort(p.GetValue())].Add(p);
	}

	public static int Sort(int value){
		if (value < highBlockValue) {
			return value % blockStep;
		}
		return blocks;
	}

	
}

public class Block {
	ArrayList players;
	
	public void Add (Player p){
		players.Add(p);
	}

	public Player Pair(){
		int pairs = players.Count % 2;
		for(int i = 0; i < pairs; i++){
			
		}
		players.RemoveRange(0, pairs);
		if(players[0] != null){
			return players[0] as Player;
		}
		return null;
	}
}