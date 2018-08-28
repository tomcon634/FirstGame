using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    public static bool playerSafe = true;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "zombie")
        {
            playerSafe = false;
        } else if (col.collider.tag == "safe")
        {
            playerSafe = true;
            DeathCollider.killed = false;
        }

        if (col.collider.name == "bounce_wall1" || col.collider.name == "bounce_wall2")
        {
            Physics.IgnoreCollision(col.collider, transform.GetComponent<Collider>());
        }
    }
}
