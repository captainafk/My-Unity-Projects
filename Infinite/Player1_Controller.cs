using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player1_Controller : MonoBehaviour {
	
	private Vector3 targetPos;
	private double MaxHeight = 3.5;
	private double MinHeight = 1.5;
	public Text healthText;
	
	public static int health = 10;
	
	// Update is called once per frame
	void Update () {
		if (health <= 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			health = 10;
		}
		healthText.text = "Health: " + health.ToString();
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z < MaxHeight){
			targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
			transform.position = targetPos;
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > MinHeight){
			targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
			transform.position = targetPos;
		}
	}
}
