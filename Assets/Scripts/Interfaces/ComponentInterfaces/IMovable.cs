
using Interfaces.ConfigInterfaces;
using UnityEngine;

public interface IMovable
{
    void Init(IMovementConfig movementConfig);
    void MoveTowards(Vector3 direction, float deltaTime);
    void RotateTowards(Vector3 direction, float deltaTime);
}
