using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidSpawner : MonoBehaviour {

	/// <summary>
	/// Made by Jerry Sam
	/// </summary>

	[SerializeField]private float _spawnDelay;
	[SerializeField]private float _acidPoolW;
	[SerializeField]private float _acidPoolH;
	[SerializeField]private GameObject _acidDrop;

	private int _spawnedAcid;

	void Update(){
		if (_spawnedAcid < _acidPoolH) { 
			SpawnAcid ();
			_spawnedAcid++;
		}
	}

	public void SpawnAcid(){
		for (int i = 0; i < (_acidPoolW * 2f + 1); i++) {
			Vector3 _spawnPos = new Vector3 (Random.Range(-_acidPoolW,_acidPoolW), this.transform.position.y);
			Instantiate (_acidDrop, _spawnPos, Quaternion.identity);
		}
	}
}
