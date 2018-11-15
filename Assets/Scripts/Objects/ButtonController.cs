using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    private Animator anim;

    public bool IsClicked;

    //Check player collision
    //Activate Puist animatie
    //Activate Huig animatie

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Player")
        {
            IsClicked = true;

            //Button animatie
            anim.SetBool("ButtonClicked", true);
        }
    }
}
