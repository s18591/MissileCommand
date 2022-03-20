using UnityEngine;

public interface ITargetChooser
{
    void AddTarget();
    GameObject GetTarget();
    void RemoveTarget();
}