using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidMovement : MonoBehaviour {

	/// <summary>
	/// Made by Jerry Sam
	/// </summary>

	private Rigidbody2D _rb;
	private float _spd = 2000;
	private int _dir;

	void Start(){
		_rb = GetComponent<Rigidbody2D>(); 
		_dir = 1;
		InvokeRepeating ("MoveSubstance", 10, 0.1f);
	}

	void MoveSubstance () {
//		_dir = Random.Range (1, 2);
		if (_dir == 1) {
			Debug.Log ("move left");
			_rb.AddForce (-transform.right * _spd * Time.deltaTime);
			_dir = 2;
		} 
		else if (_dir == 2) {
			Debug.Log ("move right");
			_rb.AddForce (transform.right * _spd * Time.deltaTime);
			_dir = 1;
		} 
	} 

}
