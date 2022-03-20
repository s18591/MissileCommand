using UnityEngine;

public interface IMissileSpawner
{
    Vector2 mousePos { get; set; }
    Vector2 objPos { get; set; }

    void DestroyerSpawn();
    void MissileSpawn();
    void Start();
}