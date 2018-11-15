using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crypto : MonoBehaviour {

	private char[] _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
	private char[] _credits1 = "LGTTAUCO".ToCharArray();
	private char[] _credits2 = "VTQAVQGPFCPI".ToCharArray();
	private string[] _decrypted1 = new string[8];
	private string[] _decrypted2 = new string[12];

	private string _totalDecrypt1;
	private string _totalDecrypt2;

	void Start(){
		Decrypt ();
	}

	public void Decrypt (){ 
		int value;
		string decryptedChar;
		for (int i = 0; i < _credits1.Length; i++) {
			//check the index in alpha of the char in credits1
			value = Array.IndexOf (_alpha, _credits1.GetValue (i));
			if (value == 0) {
				decryptedChar = "Y";
			} else if (value == 1) {
				decryptedChar = "Z";
			} else {
				//set decrypted string to the character on index (value - 2) 
				decryptedChar = _alpha.GetValue (value - 2).ToString ();
			}

			_decrypted1 [i] = decryptedChar;
			_totalDecrypt1 = _totalDecrypt1 + _decrypted1 [i];
		}
 
		for (int i = 0; i < _credits2.Length; i++) {
			//check the index in alpha of the char in credits1
			value = Array.IndexOf (_alpha, _credits2.GetValue (i));
			if (value == 0) {
				decryptedChar = "Y";
			} else if (value == 1) {
				decryptedChar = "Z";
			} else {
				//set decrypted string to the character on index (value - 2) 
				decryptedChar = _alpha.GetValue (value - 2).ToString ();
			}

			_decrypted2 [i] = decryptedChar;
			_totalDecrypt2 = _totalDecrypt2 + _decrypted2 [i];
		}

		Debug.Log("AcidMovement.cs, AcidSpawner.cs, CorrectAcidSize.cs, RandomItemSpawner.cs, Interact.cs and Crypto.cs are made by : " + _totalDecrypt1);
		Debug.Log ("PlayerMovement, are made by : " + _totalDecrypt2);
	}
}
	