using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawn : MonoBehaviour {

	/// <summary>
	/// Made by Jerry Sam
	/// </summary>

	[SerializeField]private GameObject[] _locationList;
	[SerializeField]private GameObject _objectOfChoice;

	private int _locationLength;
	private GameObject _chosenLocation;

	void Start(){
		
		_locationLength = _locationList.Length;
		SpawnObject ();
		//Debug.Log (chosenLocation + " " + chosenLocation.transform.position);
	}

	private void SpawnObject(){
		_chosenLocation = _locationList[Random.Range (0, _locationLength)];
		Instantiate<GameObject> (_objectOfChoice, _chosenLocation.transform.position, Quaternion.identity);
	}
}
