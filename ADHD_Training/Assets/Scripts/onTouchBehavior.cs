using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS CLASS AND ITS ONTOUCH FUNCTION WILL BE IMPLEMENTED IN THE VR SOFTWARE.
// IT DOES NOT SERVE A PURPOSE IN UNITY AND NEEDS TO BE CHANGED.

public class onTouchBehavior : MonoBehaviour {

	public static int grandTotalScore;

	void onTouch() {
		grandTotalScore += 1;
	}
}
