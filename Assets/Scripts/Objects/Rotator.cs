using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private float _spd = 12;

	void Update(){
		StartRotating ();
	}

	public void StartRotating(){
		transform.Rotate(Vector3.forward * _spd * Time.deltaTime);
	}
}
