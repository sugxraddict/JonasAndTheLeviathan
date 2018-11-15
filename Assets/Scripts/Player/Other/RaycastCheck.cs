using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCheck : MonoBehaviour {

    public LayerMask mask;

    private float theDistance;
    Vector2 orientation;


    // Update is called once per frame
    void Update ()
    {
        //print(RaycastChecker());
	}

    public string RaycastChecker()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x != 0)
            orientation = new Vector2(x, 0);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, orientation, 1f, mask);
        Debug.DrawRay(transform.position, orientation, Color.green);

        if (hit.collider != null)
            return hit.transform.tag;

        return "no hit";
    }
}
