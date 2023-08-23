using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float playerJump = 10;
    public Rigidbody2D myRigidbody;

    private bool isTouchingRightWall = false;
    private bool isTouchingLeftWall = false;

    void Start()
    {
        myRigidbody.velocity = Vector2.right * playerJump;
    }

    void Update()
    {
        // Check for input and adjust velocity based on wall touch
        if (Input.GetKeyDown(KeyCode.Space) || IsTouchInput())
        {
            if (isTouchingRightWall)
            {
                myRigidbody.velocity = Vector2.left * playerJump;
            }
            else if (isTouchingLeftWall)
            {
                myRigidbody.velocity = Vector2.right * playerJump;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("RightWall"))
        {
            isTouchingRightWall = true;
            isTouchingLeftWall = false;
        }
        else if (collision.collider.CompareTag("LeftWall"))
        {
            isTouchingLeftWall = true;
            isTouchingRightWall = false;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("RightWall") || collision.collider.CompareTag("LeftWall"))
        {
            isTouchingRightWall = false;
            isTouchingLeftWall = false;
        }
    }

    bool IsTouchInput()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    return true;
                }
            }
        }
        return false;
    }
}