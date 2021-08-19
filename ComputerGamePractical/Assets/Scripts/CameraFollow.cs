using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    float xWidthC = 1.2f;
    float yHeightC = 5f;

     void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, -xWidthC, xWidthC),
            Mathf.Clamp(player.position.y, -yHeightC, yHeightC), transform.position.z);    
    }
}
