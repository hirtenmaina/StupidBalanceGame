using UnityEngine;
using System.Collections;

public class StartGameMenu : MonoBehaviour {
	

	void Start(){
	}

	void Update () {
	
	}

	public void StartGame()
	{
		Application.LoadLevel (1);// 1 refers to the second scene in the build settings.
	}

	public void Exit(){
		Application.Quit();
	}
}
