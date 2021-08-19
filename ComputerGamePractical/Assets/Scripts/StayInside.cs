using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    //float xWidthP = 6.6f;
    //float yHeightP = 9.2f;
    float xWidthP;
    float yHeightP;
    // Update is called once per frame
    void Update()
    {
        xWidthP = (Screen.width - 34) / 100;
        yHeightP = (Screen.height - 54) / 100;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xWidthP, xWidthP),
            Mathf.Clamp(transform.position.y, -yHeightP, yHeightP), 0);

    }
}
