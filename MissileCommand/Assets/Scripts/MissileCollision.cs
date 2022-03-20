using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollision : MonoBehaviour, IMissileCollision
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        BoomSpawner.Instance.BoomSpawn();
    }
}
