using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public GameObject prefab; 
	private float rand_x; 
	private int SCREEN_WIDTH = 12; 
	private int objWaitTime = 200; 
	private int stored_time = 0; 
	public int freq; 

	// Use this for initialization
	void Start () {
		 
	}

	void Spawn() {
		Instantiate (prefab, new Vector3 (rand_x, 8, 0), Quaternion.identity); 
	}

	int Randomize() {
		if (Random.value < 0.5)
			return -1;
		else
			return 1; 
	}
		
	// Update is called once per frame
	void Update () {
		float real_time = Time.realtimeSinceStartup; 
		stored_time++; 

		if (stored_time*freq > objWaitTime) {
			rand_x = (Random.value * SCREEN_WIDTH) * Randomize();
			Spawn (); 

			stored_time = 0; 
		}
		
	}
}
