using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour {

    [SerializeField]
    private float _climbingSpeed = 0.3f;

    private RaycastCheck raycastCheck;
    private PlayerMovement pm;
    private InputManager im;

    void Start()
    {
        raycastCheck = GetComponent<RaycastCheck>();
        im = GetComponent<InputManager>();
        pm = GetComponent<PlayerMovement>();
    }
    
    // Update is called once per frame
    void Update ()
    {
        Climber();
        WallJump();

    }

    void Climber()
    {
        if (raycastCheck.RaycastChecker() == "Climb" && Input.GetKey(KeyCode.W))
            transform.Translate(new Vector2(0, _climbingSpeed));
    }

    void WallJump()
    {
        if (raycastCheck.RaycastChecker() == "WallJump")
            pm.grounded = true;
    }
}