using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMech : MonoBehaviour {

    private bool hit = false;
    private double counter = 0;

    private int max = 5;
    private double speed = 0.03;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (hit && counter <= max)
        {
            transform.Translate(0f, 0f, (float) speed);
            counter += speed;
        } else if (!hit && counter >= 0)
        {
            transform.Translate(0f, 0f, (float) -speed);
            counter -= speed;
        }

        if (counter >= max)
        {
            hit = false;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Ethan")
        {
            hit = true;
        }
    }
}
