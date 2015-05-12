using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour {
	public List<GameObject> cubes;
	public GameObject planet;
	public float reds;
	public Color R6;
	public Color R4;
	public Color R2;
	public Color C6;
	public Color C4;
	public Color C2;


void Update(){
	int amount = 0;
		Debug.Log ("BARK");
	for (int i = 0; i <= 7; i++) {
			reds = cubes[i].GetComponent<Renderer>().material.color.r;
		//	Debug.Log (reds);
			if (reds > 0.1f){
				amount ++;
				//Debug.Log ("PLUS");
			}
		}
		if (amount == 7) {
			planet.GetComponent<Renderer> ().material.color = R6;
		} else if (amount == 6) {
			planet.GetComponent<Renderer> ().material.color = R4;
		} else if (amount == 5) {
			planet.GetComponent<Renderer> ().material.color = R2;
		} else if (amount == 3) {
			planet.GetComponent<Renderer> ().material.color = C2;
		} else if (amount == 2) {
			planet.GetComponent<Renderer> ().material.color = C4;
		} else if (amount == 1) {
			planet.GetComponent<Renderer> ().material.color = C6;
		} else {
			planet.GetComponent<Renderer> ().material.color = Color.white;
		}


		if (amount == 8 || amount == 0){
			Debug.Log ("GAMEOVER");
			Application.LoadLevel (2);// 1 refers to the second scene in the build settings.
		
		}
		Debug.Log("Amount:"+amount);
	}



}