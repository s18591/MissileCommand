using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObjectPossition : MonoBehaviour, IGetObjectPossition
{
    public static GetObjectPossition Instance { get; set; }
    public Vector2 targetPos;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetObjectPos();
    }

    public void GetObjectPos()
    {
        MissileSpawner.Instance.mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        MissileSpawner.Instance.objPos = Camera.main.ScreenToWorldPoint(MissileSpawner.Instance.mousePos);
    }


}
