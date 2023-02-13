using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void FixedUpdate()
    {
        //get the current mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        //set the collider position to the mouse position
        transform.position = mousePos;
    }
}
