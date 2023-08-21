using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemys;
    public float spawnRate = 2;
    private float timer = 0;
    public float spawnOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        
        }
        else
        {
            Instantiate(Enemys, transform.position, transform.rotation);
            timer = 0;
        }
    }
    void spawnEnemy()
    {
        float lowestPoint = transform.position.y - spawnOffset;
        float highestPoint = transform.position.y + spawnOffset;
        Instantiate(Enemys, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }

   
}
