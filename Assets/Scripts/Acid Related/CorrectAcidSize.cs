using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAcidSize : MonoBehaviour {

	/// <summary>
	/// Made by Jerry Sam
	/// </summary>

	[SerializeField]private GameObject _targetCam;
	private Camera _cam;

	void Start(){
		_cam = _targetCam.GetComponent<Camera> ();
	}

	void Update(){
		ChangeSize ();
	}

	public void ChangeSize(){
		transform.localScale = new Vector2 ((_cam.orthographicSize * 2), (_cam.orthographicSize * 2));
	}
}
