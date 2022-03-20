using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommetCollision : MonoBehaviour, ICommetCollision
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "Commet(Clone)")
        {
            MissileScoreCounter.Instance.AddMissile();
            ScoreManager.Instance.AddScore();
            Destroy(gameObject);
        }
    }
}
