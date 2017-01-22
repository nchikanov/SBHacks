using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private Rigidbody2D rb2d; 
	public Vector2 velocity; 

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		rb2d.MovePosition (rb2d.position + velocity * Time.fixedDeltaTime); 
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Ground")) { // check for Pickup
			Destroy(gameObject); // called every time we touch a 2D trigger collider
		}
	} // called when player first touches 2D trigger collider 
}
