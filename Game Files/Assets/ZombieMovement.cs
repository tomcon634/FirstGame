using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {

    public Transform target;
    public float speed;
    private bool outOfBounds = false;
    Animator anim;

    private float start_x, start_z;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

        start_x = transform.position.x;
        start_z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        CheckBounds();

        Vector3 direction = target.position - transform.position;
        Vector3 new_direction = new Vector3(direction.x, 0, direction.z);
        Quaternion rotation = Quaternion.LookRotation(new_direction);
        transform.rotation = rotation;

        Vector3 new_position = new Vector3(target.position.x, transform.position.y, target.position.z);
        if (PlayerCollider.playerSafe)
        {
            transform.position = Vector3.MoveTowards(transform.position, new_position, 0f);
            anim.Play("idle");
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, new_position, speed);
            anim.Play("walk");
            anim.speed = speed * 15;
        }

        if (DeathCollider.killed || outOfBounds)
        {
            transform.position = new Vector3(start_x, transform.position.y, start_z);
        }
	}

    private void CheckBounds()
    {
        if (transform.localPosition.z >= 200 || transform.localPosition.z <= 7)
        {
            outOfBounds = true;
        }
    }
}
