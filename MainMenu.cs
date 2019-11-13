using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	int load_scene_id = 1;	// 1 - Structural	2 - Architectural
	
    public void PlayGame (){
		
		SceneManager.LoadScene(load_scene_id);
	}
	
	public void QuitGame(){
		Debug.Log("Quit!");
		Application.Quit();
	}
	
	public void ChangeView(){
		
		if (load_scene_id == 1){
			load_scene_id = 2;
		}else{
			load_scene_id = 1;
		}
	}
	
}