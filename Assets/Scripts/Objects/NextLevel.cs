using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    public static float levelCount = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "PlayerGroundCheck")
        {
            Next();
            //Debug.Log(levelCount);
        }
    }

    void Next()
    {
        //SceneManager.LoadScene(SceneManager.sceneCount + 1);
        levelCount += 1;
    }
}
