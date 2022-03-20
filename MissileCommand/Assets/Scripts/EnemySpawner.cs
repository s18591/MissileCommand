using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour, IEnemySpawner
{

    public Transform spawnCommet;
    private float timer { get; set; }
    private float timeTilNextSpawn { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    public void Spawn()
    {
        if (timer > timeTilNextSpawn)
        {
            timeTilNextSpawn = Random.Range(1, 15);
            Instantiate(spawnCommet, new Vector2(transform.position.x, transform.position.y), spawnCommet.rotation);
            timer = 0;
        }
    }
}
