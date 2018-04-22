using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTouchBehavior : MonoBehaviour {

	public int grandTotalScore;

	void onScore() {
		grandTotalScore = grandTotalScore + 1;
	}
}
