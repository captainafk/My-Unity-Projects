using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1_Spawner : MonoBehaviour {

	public GameObject[] obstaclePatterns;
	
	private float timeBetweenSpawn;
	public float startTimeBetweenSpawn = 3;
	public float decreaseTime = 0.005f;
	public float minTime = 0.5f;
	
	private void Update(){
		if (timeBetweenSpawn <=0){
			int rand = Random.Range(0, obstaclePatterns.Length);
			Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
			timeBetweenSpawn = startTimeBetweenSpawn;
			
			if (startTimeBetweenSpawn > minTime){
				startTimeBetweenSpawn -= decreaseTime;
			}
			
		}
		else {
			timeBetweenSpawn -= Time.deltaTime;
		}
	}
}
