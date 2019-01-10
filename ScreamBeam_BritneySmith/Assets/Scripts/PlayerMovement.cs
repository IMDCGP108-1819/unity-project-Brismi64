using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // set Jump and Speed values
    public float Speed;
    public float Jump;

    private Rigidbody2D RB;

    // define 2D Rigidbody
	void Start ()
    {
        RB = GetComponent<Rigidbody2D>();
	}
	
    // Player moves non-stop to the right and jumps when space is pressed
	void Update ()
    {

        RB.velocity = new Vector2(Speed, RB.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.velocity = new Vector2(RB.velocity.x, Jump);
        }
	}
}
