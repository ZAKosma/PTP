using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Card{
	int value{
		get;
	}

	bool faceUp{
		get;
	}

	void Flip();
}