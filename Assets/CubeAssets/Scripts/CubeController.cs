using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CubeController : MonoBehaviour {

	public Material[] matofobject;
	Renderer rend;

	void Start ()
	{
		Debug.Log("SCRIPT IS RUNNING!!!");
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = matofobject[0];
		Invoke("ChangeColor", UnityEngine.Random.Range(3, 20));
	}

	void ChangeColor()
	{
		float randomTime = UnityEngine.Random.Range(7, 20);
		if (rend.sharedMaterial == matofobject[0]) {
			rend.sharedMaterial = matofobject[1];
			Invoke("ChangeColor", 2);
			Debug.Log("changing to cyan now!!!");
			onTouchBehavior.grandTotalScore = onTouchBehavior.grandTotalScore + 1;
			Debug.Log("score should be 1 more than ^^^ : " + onTouchBehavior.grandTotalScore);
		} else {
			rend.sharedMaterial = matofobject[0];
			Invoke("ChangeColor", randomTime);
		}


	}
	
}




