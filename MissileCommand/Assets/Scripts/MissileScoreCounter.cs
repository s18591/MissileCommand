using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileScoreCounter : MonoBehaviour, IMissileScoreCounter
{

    public static MissileScoreCounter Instance { get; set; }
    public int missileCounter;

    // Start is called before the first frame update
    void Start() => Instance = this;

    // Update is called once per frame
    void Update() => GetComponent<Text>().text = "" + missileCounter;

    public void RemoveMissile() => missileCounter--;
    public void AddMissile() => missileCounter++;
}
