using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {

    static double speed = 0.5;
    double moveX, moveY, moveZ;

    // Use this for initialization
    void Start() {
        moveX = speed * Random.Range((float) -1.0, (float) 1.0);
        moveY = speed * Random.Range((float) -1.0, (float) 1.0);
        moveZ = speed * Random.Range((float) -1.0, (float) 1.0);
    }

    // Update is called once per frame
    void Update() {
        transform.Translate((float)moveX, (float)moveY, (float)moveZ);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "right_wall" || col.collider.name == "left_wall")
        {
            moveX = -moveX;
        }
        if (col.collider.name == "ceiling" || col.collider.name == "floor")
        {
            moveY = -moveY;
        }
        if (col.collider.name == "bounce_wall1" || col.collider.name == "bounce_wall2")
        {
            moveZ = -moveZ;
        }
    }
}
