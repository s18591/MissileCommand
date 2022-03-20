using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommetController : MonoBehaviour, ICommetController
{

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = TargetChooser.Instance.GetTarget();
        StartCommet();
    }
    public void StartCommet() => GetComponent<Rigidbody2D>().velocity = ((target.transform.position - transform.position) / Vector2.Distance(target.transform.position, transform.position)) * 5;
}
