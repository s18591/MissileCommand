using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DestroyerController : MonoBehaviour, IDestroyerController
{
    private float timer;

    void Update() => timer += Time.deltaTime;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Missile(Clone)" || timer > 1)
            Destroy(gameObject);
    }
}
