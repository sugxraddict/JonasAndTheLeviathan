using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

    private Animator anim;

    private ButtonController Click;

    // Use this for initialization
    void Start ()
    {
        Click = GetComponent<ButtonController>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        ButtonStages();
    }

    void ButtonStages()
    {

        if (GameObject.Find("Button3").GetComponent<ButtonController>().IsClicked)
        {
            Debug.Log("Clicked2");
            anim.SetBool("FinishHazard", true);
        }
    }
}
