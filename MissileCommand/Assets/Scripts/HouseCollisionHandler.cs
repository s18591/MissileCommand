using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollisionHandler : MonoBehaviour, IHouseCollisionHandler
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Commet(Clone)")
            Destroy(gameObject);
    }
}
