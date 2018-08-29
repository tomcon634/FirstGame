using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavabrickBehaviour : MonoBehaviour {

    public float speed;
    public float range;
    private float counter = 0f;
    private bool down = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // range != 0
        if (counter >= range)
        {
            down = false;
        } else if (counter <= 0) {
            down = true;
        }

		if (down)
        {
            transform.Translate(0f, -speed, 0f);
            counter += speed;
        } else
        {
            transform.Translate(0f, speed, 0f);
            counter -= speed;
        }
	}
}
