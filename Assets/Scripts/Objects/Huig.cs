using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huig : MonoBehaviour {

    private ButtonController Click;

    private Animator anim;

    // Use this for initialization
    void Start ()
    {
        Click = GetComponent<ButtonController>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.Find("Button1").GetComponent<ButtonController>().IsClicked)
        {
            anim.SetBool("MovingHuig", true);
        }
	}
}
