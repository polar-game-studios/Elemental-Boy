using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D RB;

    public float MoveSpeed = 6f;
    public float JumpHeight = 6f;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            RB.velocity = new Vector2(MoveSpeed, RB.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            RB.velocity = new Vector2(-MoveSpeed, RB.velocity.y);
        }

        if (Input.GetKey("space"))
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpHeight);
        }
    }
}

/*----------------------------------NOTE----------------------------------
 * add rigidbody to your player so you can use the gravityscale modifier
 * play around until you think it feeels right
 --------------------------------------------------------
