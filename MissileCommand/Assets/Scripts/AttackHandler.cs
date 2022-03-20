using UnityEngine;

public class AttackHandler : MonoBehaviour, IAttackHandler
{
    public static AttackHandler Instance { get; set; }
    public KeyCode fire;

    public void Start() => Instance = this;

    public void Update() => Attack();

    public void Attack()
    {
        if (Input.GetKeyDown(fire) && MissileScoreCounter.Instance.missileCounter > 0)
        {
            MissileSpawner.Instance.MissileSpawn();
            MissileSpawner.Instance.DestroyerSpawn();
            MissileScoreCounter.Instance.RemoveMissile();
        }
    }
}