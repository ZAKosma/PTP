using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierCard : Card {

	private int _value;
	private bool _faceUp;

	public MultiplierCard(int amt) {
		_value = amt;
		faceUp = false;
	}

	public int value {
		get{
			if(faceUp){
				return _value;
			}
			return 0;
		}
	}

	public bool faceUp{
		get{
			return _faceUp;
		}
		set{
			_faceUp = faceUp;
		}
	}

	public void Flip(){
		faceUp = !faceUp;
	}
}