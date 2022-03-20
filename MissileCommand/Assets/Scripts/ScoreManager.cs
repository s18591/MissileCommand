using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour, IScoreManager
{

    public static ScoreManager Instance { get; set; }
    public int score;

    // Start is called before the first frame update
    void Start() => Instance = this;

    // Update is called once per frame
    void Update() => GetComponent<Text>().text = "" + score;

    public void AddScore()
    {
        score++;
    }
}
