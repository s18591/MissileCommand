using UnityEngine;

public class MissileSpawner : MonoBehaviour, IMissileSpawner
{
    public Vector2 mousePos { get; set; }
    public Vector2 objPos { get; set; }
    public Transform missile;
    public Transform destroyer;
    public GameObject shooter;
    public static MissileSpawner Instance { get; set; }

    public void Start() => Instance = this;

    public void MissileSpawn() => Instantiate(missile, new Vector2(shooter.transform.position.x, shooter.transform.position.y), missile.rotation);
    public void DestroyerSpawn() => Instantiate(destroyer, objPos, destroyer.rotation);
}