using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float maxSpeed = 7f;
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = transform.position;

		Vector3 positionChange = new Vector3(0, maxSpeed * Time.deltaTime, 0 );

		pos += transform.rotation * positionChange;


		transform.position = pos;
		
	}
}
