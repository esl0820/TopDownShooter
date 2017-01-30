using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float speed = 1f;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
		
	}

	void Movement () {
		//Move Forwards and Backwards
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -speed/3);
		}

		//Turn Left and Right
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, rotationSpeed, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, -rotationSpeed, 0);
		}
	}
}
