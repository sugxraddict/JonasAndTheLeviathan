using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    //Animation
    Animator anim;
    InputManager im;

    PlayerMovement pm;
    PlayerHealth ph;

    //Up and Down Animation
    private bool UporDown = false;

    private bool canDie = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        im = GetComponent<InputManager>();
        pm = GetComponent<PlayerMovement>();
        ph = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        MovingDirection();
    }

    void MovingDirection()
    {
        /*
        //Idle Movement
        if (!im.Left() && !im.Right())
        {
            anim.SetBool("Idle", true);
        }
        */


        //Left Movement
        if (im.Left())
        {
            transform.localScale = new Vector2(0.6f, 0.6f);
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);
        }
        //Right Movement
        else if (im.Right())
        {
            transform.localScale = new Vector2(-0.6f, 0.6f);
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);
            anim.SetBool("Jump", false);
        }
        else
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Idle", true);
            anim.SetBool("Jump", false);
        }

        //Jumping
        if (!pm.grounded)
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Idle", false);
        }
        else if (pm.grounded && !im.Jump())
        {
            anim.SetBool("Jump", false);
        }
        else if (pm.grounded && !im.Jump() && !im.Left() && !im.Right())
        {
            anim.SetBool("Idle", true);
        }

        // Death
        if (ph.HealthState == PlayerHealth.HealthStates.third)
        {
            anim.SetBool("Death", true);
            anim.SetBool("Idle", false);
            anim.SetBool("Jump", false);
            anim.SetBool("Walk", false);

            canDie = true;
            StopAllCoroutines();
            StartCoroutine("OnDeath");
        }
    }

    IEnumerator OnDeath()
    {
        if (canDie)
        {
        }

        yield return null;
    }
}
