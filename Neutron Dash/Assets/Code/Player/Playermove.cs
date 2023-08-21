using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float playerJump = 10;
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
       // myRigidbody.velocity = Vector2.left * playerJump;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.left * playerJump;
        }  
    }

}
