using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){

		GameMng.health = 10;
		SceneManager.LoadScene("Week 4");
	}
	
	public void QuitGame() {
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
