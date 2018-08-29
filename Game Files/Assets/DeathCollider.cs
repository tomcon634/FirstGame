using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour {

    public Transform respawnPoint;
    public static bool killed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Ethan")
        {
            col.transform.position = respawnPoint.transform.position;
            killed = true;
        }
    }
}
