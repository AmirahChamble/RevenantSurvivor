using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {
	public float rotationSpeed = 45f; //degrees per second

	Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (player == null){
			//find the player ship
			GameObject go = GameObject.Find("PlayerShip");

			if (go != null) {
				player = go.transform;
			}
		}
		// I could've used else statement but this works just fine
		if(player == null){
			return; //try again next frame
		}
		// at this point we either found the player of they don't exist

		//Here we know for sure we have a player so we turn to face it 

		Vector3 direction = player.position - transform.position; 
		direction.Normalize ();

		//finds angle to point enemy towares player
		float zAngle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90 ;

		Quaternion desiredRotation = Quaternion.Euler (0, 0, zAngle);

		///sets rotations, old rotation, desired degree of rotation, and the amount of degrees it can turn a second.
		transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
		
	}
}
