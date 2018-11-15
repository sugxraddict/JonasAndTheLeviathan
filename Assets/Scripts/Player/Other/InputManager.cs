using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //public bool Up() {return Input.GetKey(KeyCode.W);}
    //public bool Down() {return Input.GetKey(KeyCode.S);}
    public bool Left() {return Input.GetKey(KeyCode.A);}
    public bool Right() {return Input.GetKey(KeyCode.D);}
    public bool Jump() {return Input.GetKeyDown(KeyCode.Space);}
    //public bool JumpRelease() {return Input.GetKeyUp(KeyCode.Space);}
}
