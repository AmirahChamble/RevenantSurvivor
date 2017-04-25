using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	//the assigned values are default because variables are public, see Inspection editor to see actual values in gameplay
	public float maxSpeed = 5.0f;
	public float rotSpeed = 90f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Rotates the Ship
		//Quarternian = a way to track rotations
		//Grabs rotation quaternion
		Quaternion rot = transform.rotation;
		// eulerAngles = angles of z
		//grabs z euler angle
		float z = rot.eulerAngles.z; 
		//change z angle based on input
		z -= Input.GetAxis ("Horizontal") * rotSpeed * Time.deltaTime;
		//recreate the quaternion
		rot = Quaternion.Euler (0,0,z);
		//feed quaternion into the rotation
		transform.rotation = rot; 



		//Moves the Ship
		// returns a float from -1.0 to 1.0
		// Input.GetAxis ("Vertical"); this ^^^
		Vector3 pos = transform.position;

		//When Input.GetAxis("Vertical") is != 0; ship will move Verically, if = 0 it will not.
		// was going to be an if statement but got errors i'm not willing to resolve -4/13/17
		Vector3 positionChange = new Vector3(0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0 );

		pos += rot * positionChange;
	
		transform.position = pos;
		
	}
}
