using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour, IMissileController
{
    // Start is called before the first frame update

    public float timer { get; private set; }
    public float distance { get; private set; }
    public static MissileController Instance { get; set; }

    void Start()
    {
        Instance = this;
        GetObjectPossition.Instance.targetPos = MissileSpawner.Instance.objPos;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        calcDistance();
        Move();

    }
    public void Move() => transform.position = Vector2.Lerp(transform.position, GetObjectPossition.Instance.targetPos, distance);

    public void calcDistance()
    {
        if (timer > .04f)
        {
            distance += .01f;
            timer = 0;
        }
    }
}
