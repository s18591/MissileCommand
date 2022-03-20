using UnityEngine;

public interface IMissileCollision
{
    void OnTriggerEnter2D(Collider2D collision);
}