﻿
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollisionTest : MonoBehaviour {

	public float interval;
	private Color cubeColor;

	
	void Update(){	

		cubeColor = Color.cyan;
		if (interval > 0 && this.gameObject.GetComponent<Renderer>().material.color == cubeColor) {
			interval -= Time.deltaTime;
			//Debug.Log("Timer set");
		} else if (interval <= 0 && this.gameObject.GetComponent<Renderer>().material.color == cubeColor) {
	
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			//Debug.Log ("RED");
		}
	}

	
	void OnCollisionEnter() {
		
		gameObject.GetComponent<Renderer>().material.color = Color.cyan;
		//Debug.Log ("Collided Cube");
		interval = 5f;

	}
	

}

