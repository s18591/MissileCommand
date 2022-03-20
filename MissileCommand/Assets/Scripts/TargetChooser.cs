using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChooser : MonoBehaviour, ITargetChooser
{

    public List<GameObject> targets = new List<GameObject>();

    public static TargetChooser Instance { get; set; }

    private void Awake()
    {
        Instance = this;
        AddTarget();
    }
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        RemoveTarget();
    }

    public GameObject GetTarget()
    {
        var gameObject = targets[Random.Range(0, targets.Count)];
        return gameObject;
    }
    public void RemoveTarget()
    {
        foreach (GameObject Item in targets)
        {
            if (Item == null)
            {
                targets.Remove(Item);
            }
        }
    }
    public void AddTarget()
    {
        for (int i = 1; i <= 4; i++)
        {
            var target = GameObject.Find("House" + i);
            targets.Add(target);
        }
    }
}
