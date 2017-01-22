using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player; 
	private Vector3 offset; 

	void Start() {

		offset = transform.position - player.transform.position; // attached to camera game object
	}

	// will run after
	void LateUpdate() {
		// this happens every frame
		transform.position = player.transform.position + offset; // player moves into new position alligned with the player

	}
}

