using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

	public float interval;
	private Color cubeColor;

	
	void Update (){	
		//cubeColor = gameObject.GetComponent<Renderer> ().material.color;
		cubeColor = Color.cyan;
		if (interval > 0 && this.gameObject.GetComponent<Renderer>().material.color == cubeColor) {
			interval -= Time.deltaTime;
		} else {
		
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		
		}
	}

	
	void OnCollisionEnter() {
		
		gameObject.GetComponent<Renderer>().material.color = Color.cyan;
		Debug.Log ("Collided Cube");	
		Debug.Log(interval);
	}
	

}
