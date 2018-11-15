using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    public float jumpHeight = 15f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsBounce;

    public bool grounded;
    public bool bounce;
    private bool doubleJumped;
    private bool canWalk = true;

    private float _bounceBoost = 30.0f;

    private InputManager im;
    Rigidbody2D _rb;

    private Animator anim;

    private NextLevel nLevel;
    private float levelCount;

    // Use this for initialization
    void Start ()
    {
        _rb = GetComponent<Rigidbody2D>();
        im = GetComponent<InputManager>();
        anim = GetComponent<Animator>();
        nLevel = GetComponent<NextLevel>();
    }

	
	// Update is called once per frame
	void Update ()
    {
        Walking();
        Jumping();
        OffBorder();
        Debug.Log(levelCount);
	}

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        bounce = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsBounce);
    }

    // Walking
    void Walking()
    {
         if (im.Left())
         {
             transform.Translate(new Vector2(-_speed * Time.deltaTime, 0));
         }
         else if (im.Right())
         {
             transform.Translate(new Vector2(_speed * Time.deltaTime, 0));
         }
    }

    // Jumping
    void Jumping()
    {
        if (grounded)
            doubleJumped = false;

        if (im.Jump() && grounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpHeight);
        }

        if (im.Jump() && !doubleJumped && !grounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpHeight);
            doubleJumped = true;
        }
    }

   

    // Collision
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (bounce)
        {
            _rb.AddForce(Vector2.up * _bounceBoost, ForceMode2D.Impulse);
        }
    }


    void OffBorder()
    {
        levelCount = NextLevel.levelCount;
        Vector2 playerPos = transform.position;

        if (levelCount == 0)
        {

            playerPos.x = Mathf.Clamp(transform.position.x, -22, 22);
            //playerPos.y = Mathf.Clamp(transform.position.y, -12, 11);

            transform.position = playerPos;
        }
        else if (levelCount == 1)
        {
            playerPos.x = Mathf.Clamp(transform.position.x, -34, 33);

            transform.position = playerPos;
        }
        else if (levelCount == 2 || levelCount == 3)
        {
            playerPos.x = Mathf.Clamp(transform.position.x, -33, 98);

            transform.position = playerPos;
        }
    }

    // Teleportation

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "Finish1")
        {
            transform.position = new Vector2(-15, -20);
        }
        else if (col.transform.tag == "Finish2")
        {
            transform.position = new Vector2(-30, -85);
        }
        else if (col.transform.tag == "NextView")
        {

        }
        else if (col.transform.tag == "Finish3")
        {

        }
        else if (col.transform.tag == "Finish4")
        {

        }
    }
}