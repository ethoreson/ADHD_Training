using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MenuToggle : MonoBehaviour {
	public VRTK_ControllerEvents controllerEvents;
	public GameObject menu;
	bool menuState = false;

	void OnEnable(){
		//controllerEvents.buttonTwoPressed += controllerEvents_ButtonTwoPressed;
		controllerEvents.ButtonTwoReleased += controllerEvents_ButtonTwoReleased;
	}

	void OnDisable(){
		//controllerEvents.buttonTwoPressed -= controllerEvents_ButtonTwoPressed;
		controllerEvents.ButtonTwoReleased -= controllerEvents_ButtonTwoReleased;
	}

	private void controllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
	{
		menuState = !menuState;
		menu.SetActive (menuState);		//throw new System.NotImplementedException ();
	}

}
