using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprites : MonoBehaviour
{

    private enum Sprites {left, right}
    private Sprites mySprites;

    //Sprite ;
    private SpriteRenderer spr;

    public Sprite[] _sprites;

    //public float timer = 0.01f;
    //public float initialTimer = 0.5f;


    private Sprite currentSprite, nextSprite;
    private bool changingSprite;

    InputManager im;

    // Use this for initialization
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        im = GetComponent<InputManager>();

        mySprites = Sprites.left;
    }

    // Update is called once per frame
    void Update()
    {
        MovingDirection();

        if (mySprites == Sprites.left) { sprLeft(); }
        else if (mySprites == Sprites.right) { sprRight(); }
    }

    void sprLeft()
    {
        spr.sprite = _sprites[0];
    }
    void sprRight()
    {
        spr.sprite = _sprites[1];
    }

    void MovingDirection()
    {
        if (im.Left())
        {
            mySprites = Sprites.left;
        }
        else if (im.Right())
        {
            mySprites = Sprites.right;
        }
    }
}