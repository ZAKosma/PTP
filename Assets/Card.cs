using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Card{
	int value{
		get;
		set;
	}

	bool faceUp{
		get;
		set;
	}

	void Flip();
}