using UnityEngine;

public interface IHouseCollisionHandler
{
    void OnTriggerEnter2D(Collider2D collision);
}