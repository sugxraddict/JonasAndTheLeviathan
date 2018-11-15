using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

	private Rigidbody2D _rb;

	void Start(){
		_rb = GetComponent<Rigidbody2D>();

	}

	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Interactable") {
			InteractCheck ();
		}
	}

	public void InteractCheck(){

	}
}
