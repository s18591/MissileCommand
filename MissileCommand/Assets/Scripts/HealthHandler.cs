using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthHandler : MonoBehaviour, IHealthHandler
{
    void Update()
    {
        OnGameOver();
    }

    public void OnGameOver()
    {

        if (TargetChooser.Instance.targets.Count == 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
