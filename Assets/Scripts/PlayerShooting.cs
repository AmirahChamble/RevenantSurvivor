using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
	public GameObject playerBlastsPrefab; 

	public float fireDelay = 0.25f;

	public Vector3 bulletOffset = new Vector3 (0f, 1f, 0f);

	float coolDownTimer = 1f; // to avoid rapid fire, there will be a slight pause between consecutive blasts




	//Update called once per frame
	void Update () {

		coolDownTimer -= Time.deltaTime; 

		//GetButton vs GetButtonDown. GetButton if pressed down execute, GetButtonDown if pressed down Shoot once then nothing
		if(Input.GetButton("Fire1") && coolDownTimer <= 0){
			
			//Fire!!
			Debug.Log("Shots fired!!");
			coolDownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			Instantiate (playerBlastsPrefab, transform.position + offset, transform.rotation);
		}
	}
}
