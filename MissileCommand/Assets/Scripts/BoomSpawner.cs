using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomSpawner : MonoBehaviour, IBoomSpawner
{
    public Transform boom;
    public static BoomSpawner Instance { get; set; }
    // Start is called before the first frame update
    void Start() => Instance = this;
    public void BoomSpawn() => Instantiate(boom, MissileSpawner.Instance.objPos, boom.rotation);
}
