using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour {

	public int damage = 1;
	
	public float speed = 5;
	
	private void Update(){
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			//other.GetComponent<Player1_Controller>().health -= damage;
			//Debug.Log(other.GetComponent<Player1_Controller>().health);
			
			//GameManager.instance.health -= damage;
			//Debug.Log(GameManager.instance.health);
			
			Player1_Controller.health -= damage;
			Debug.Log(Player1_Controller.health);
			Destroy(gameObject);
		}else if (other.CompareTag("Wall")){
			Destroy(gameObject);
		}
	}
}
