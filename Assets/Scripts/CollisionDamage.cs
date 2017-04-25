using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {
	public int health = 1; 

	public float invulnerability = 0.5f;
	int correctLayer;

	void Start(){
		correctLayer = gameObject.layer;
	}

	// use Triggers from Box COllider 2d componenets to detect collisions
	void OnTriggerEnter2D(){
		Debug.Log ("Trigger");

		if(invulnerability <= 0){
			health--;
			invulnerability = 2f;
			gameObject.layer = 10;
		}
	}

	void Update(){
		invulnerability -= Time.deltaTime;
		if (invulnerability <= 0) {
			gameObject.layer = correctLayer;
		}

		if(health <= 0){
			Die();
		}
	}


	void Die(){
		Destroy (gameObject);
	}
}
