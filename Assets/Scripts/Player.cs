using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	public float health;

	public GameObject tracker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Translate (0, 0, speed);
		}

		Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

		Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

		float angle = GetAngle(positionOnScreen, mouseOnScreen);

		transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
	}

	float GetAngle(Vector3 a, Vector3 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
		

	void OnCollisionEnter (Collision collision) {

	}

	void ShootTracker() {

	}

	void Attack () {

	}
}
