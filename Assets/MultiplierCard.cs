using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierCard : Card {

	private int _value;
	private bool _faceUp;
	public int value {
		get{
			if(faceUp){
				return _value;
			}
			return 0;
		}
		set{
			_value = value;
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