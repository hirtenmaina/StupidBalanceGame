using UnityEngine;
using System.Collections;

public class StartGameMenu : MonoBehaviour {
	
	protected void OnGUI(){
		if (GUILayout.Button("Start Game!")){
			StartGame();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

	protected void StartGame()
	{
		Application.LoadLevel (1);// 1 refers to the second scene in the build settings.
	}

}
