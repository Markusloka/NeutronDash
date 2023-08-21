using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float movespeed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * movespeed) * Time.deltaTime;
    }
}
