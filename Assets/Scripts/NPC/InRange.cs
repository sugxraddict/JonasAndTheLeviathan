using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRange : MonoBehaviour {

    private NPC_Raycast NPC_raycastCheck;

    void Start()
    {
        NPC_raycastCheck = GetComponent<NPC_Raycast>();
    }

    // Update is called once per frame
    void Update()
    {
        RangeCheck();
    }

    void RangeCheck()
    {
        if (NPC_raycastCheck.NPC_RaycastChecker() == "Player" && Input.GetKey(KeyCode.F))
        {
            Debug.Log("Hit player.");
        }
    }
}
