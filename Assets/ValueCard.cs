using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCard : Card {
	private int _value;
	private bool _faceUp;

	public ValueCard (int amt, bool revealed){
		_value = amt;
		_faceUp = revealed;
	}

	public int value {
		get{
			if(faceUp){
				return _value;
			}
			return -1;
		}
	}

	public bool faceUp{
		get{
			return _faceUp;
		}
	}

	public void Flip(){
		_faceUp = !faceUp;
	}
}