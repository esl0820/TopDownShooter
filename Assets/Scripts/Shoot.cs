using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject stinger;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Fire ();

		
	}

	void Fire () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate(stinger, transform.position, transform.rotation);
		}
	}
}
