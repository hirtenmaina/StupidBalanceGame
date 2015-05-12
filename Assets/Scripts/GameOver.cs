using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour {
	public List<GameObject> cubes;
	private List<float> reds;
	private float amount = 0;

	void Update(){
	
	for (int i = 0; i <= 7; i++) {
			reds[i] = cubes[i].gameObject.GetComponent<Renderer>().material.color.r;
			if (reds[i]>=0 && amount<=8){
				amount ++;
				Debug.Log(amount);
			}else if (reds[i]<=0 && amount>=0){
				amount --;
				Debug.Log(amount);
			}
		}
	
	}


}