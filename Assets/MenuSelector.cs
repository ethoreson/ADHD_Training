using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using VRTK;

public class MenuSelector : MonoBehaviour {
	public VRTK_ControllerEvents controllerEvents;
	public GameObject menu;
	//bool menuState = false;

	void OnEnable(){
		//controllerEvents.buttonTwoPressed += controllerEvents_ButtonTwoPressed;
		controllerEvents.TriggerClicked += controllerEvents_TriggerClicked;
		Debug.Log ("Pointer Selection Made");
	}

	void OnDisable(){
		//controllerEvents.buttonTwoPressed -= controllerEvents_ButtonTwoPressed;
		controllerEvents.TriggerClicked -= controllerEvents_TriggerClicked;
	}

	private void controllerEvents_TriggerClicked(object sender, ControllerInteractionEventArgs e)
	{
		//menuState = !menuState;
		//menu.SetActive (menuState);		//throw new System.NotImplementedException ();
		Debug.Log("Section Executed");
	}

}
