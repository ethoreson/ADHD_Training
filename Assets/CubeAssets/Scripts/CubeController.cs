﻿using System;
using UnityEngine;
using System.Collections;


public class CubeController : MonoBehaviour {

	public Material[] matofobject;
	Renderer rend;

	void Start ()
	{
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
			onTouchBehavior.grandTotalScore = onTouchBehavior.grandTotalScore + 1;
			Debug.Log("score should be 1 more than ^^^ : " + onTouchBehavior.grandTotalScore);
		} else {
			rend.sharedMaterial = matofobject[0];
			Invoke("ChangeColor", randomTime);
		}


	}
	
}




