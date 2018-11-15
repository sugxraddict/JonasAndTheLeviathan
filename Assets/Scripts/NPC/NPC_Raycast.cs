using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Raycast : MonoBehaviour {

    public LayerMask mask;

    private float theDistance;
    Vector2 orientation;


    // Update is called once per frame
    void Update()
    {
        print(NPC_RaycastChecker());
    }

    public string NPC_RaycastChecker()
    {
        orientation = new Vector2(4f, 0);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, orientation, 4f, mask);
        Debug.DrawRay(transform.position, orientation, Color.blue);
        

        if (hit.collider != null)
            return hit.transform.tag;

        return "no hit";
    }
}
