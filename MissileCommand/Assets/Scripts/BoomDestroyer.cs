using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDestroyer : MonoBehaviour, IBoomDestroyer
{
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimeTillExplosion();
    }

    public void TimeTillExplosion()
    {
        if (timer > 1)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
