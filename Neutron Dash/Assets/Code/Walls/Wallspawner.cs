using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallspawner : MonoBehaviour
{
    public GameObject Walls;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Timer and spawnrate for the walls
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;

        }
        else
        {
            spawnWall();
            Instantiate(Walls, transform.position, transform.rotation);
            timer = 0;
        }
    }
    void spawnWall()
    {
        //spawns the  walls inside the game
        Instantiate(Walls, new Vector3(transform.position.x, 0, 0), transform.rotation);
    }
}
