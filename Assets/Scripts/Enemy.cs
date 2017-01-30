using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Health : MonoBehaviour {

	public float speed;
	float t = 0f;
	float rotate;
	public float vision;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * speed * Time.deltaTime);

		if (this.tag == "Beetle") {
			Beetle ();
		}
		if (this.tag == "Mosquito") {
			Mosquito ();
		}
		
	}

	void Beetle () {
		rotate = Random.Range (-90, 90);

		var fwd = transform.TransformDirection (Vector3.forward);

		if (Physics.Raycast (transform.position, fwd, vision)) {
			transform.Rotate (0, rotate, 0);
		}
	}

	void Mosquito () {
		transform.position.x = 3f * Mathf.Cos(t);
		transform.position.y += speed * Time.deltaTime;

		t += Time.deltaTime;
	}
}
