﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GamepadSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Joystick1Button0)) {
			SceneManager.LoadScene ("Level00");

		}

	
	}
}
