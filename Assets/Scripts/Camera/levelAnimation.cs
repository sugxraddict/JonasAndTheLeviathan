using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelAnimation : MonoBehaviour {

    private Animator anim;

    private NextLevel nLevel;
    private float levelCount;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        nLevel = GetComponent<NextLevel>();
        //levelCount = NextLevel.levelCount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        SwitchLevelAnim();
	}

    void SwitchLevelAnim()
    {
        levelCount = NextLevel.levelCount;
        //Debug.Log(levelCount);

        if (Input.GetKeyDown(KeyCode.R))
        {
            NextLevel.levelCount += 1;
        }

        if (levelCount == 1)
        {
            anim.SetFloat("LevelCounter", 1);
        }
        else if (levelCount == 2)
        {
            anim.SetFloat("LevelCounter", 2);
        }
        else if (levelCount == 3)
        {
            anim.SetFloat("LevelCounter", 3);
        }
        else if (levelCount == 4)
        {
            anim.SetFloat("LevelCounter", 4);
        }
    }
}
