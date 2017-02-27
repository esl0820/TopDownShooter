using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy Systems

public class Enemy : MonoBehaviour {

	float health;
	float speed;
	float damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (health < 1) {
			this.GetComponent<SpeedIncrease>().increaseSpeed = true;
		}
		
	}
		
}

public class Mosquito : Enemy {
	//for now just look at the player
	//when shoots, cause slight damage and stun
}

public class Beetle : Enemy {
	//follow player
	//on collision cause damage
}

public class Bee : Enemy {
	//move quickly and randomly across the screen
	//maybe in a sin wave?
	//increase speed when enemies die
	//on collision die and stun
}

//Enemy Manager

pulic class EnemyManager : MonoBehaviour {

	public List<Enemy> enemyList;

	void Start () {
		enemyList = new List<Enemy>();
	}

	void SpawnWave () {
		//when the list of enemies goes bellow 1, run this <- Does this go in update?
		//for loop for a number of enemies between 6-8
	}

	void Spawn () {
		//spawn a random type of enemy
		//add to the list of enemies
		//throw an event to the event manager telling it that something died
		enemyList.Add(Enemy);
	}

}

public abstract class EnemyEvents : MonoBehaviour {

}

public class SpeedIncrease : EnemyEvents {

	bool increaseSpeed = false;

	if (increaseSpeed == true) {
		this.GetComponent<Enemy>().speed * 1.5f;
	}

}
