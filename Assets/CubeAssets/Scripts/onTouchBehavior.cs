using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onTouchBehavior : MonoBehaviour {

	public static int grandTotalScore;
	public Text countText;

	void Start ()
	{
		grandTotalScore = 0;
		setScoreText();
	}
		
	void onScore() {
		grandTotalScore = grandTotalScore + 1;
		setScoreText();
	}

	void setScoreText()
	{
		countText.text = "Score: " + grandTotalScore.ToString();
	}
}
