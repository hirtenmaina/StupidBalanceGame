﻿using UnityEngine;
using System.Collections;

public class GameOverButtins : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}


	public void StartAgain(){
		Application.LoadLevel (1);
	}

	public void Exit(){
		Application.Quit ();
	}
}
