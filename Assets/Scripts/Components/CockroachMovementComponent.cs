using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Components
{
    public class CockroachMovementComponent : MonoBehaviour, IMovable
    {
        private IMovementConfig currentMovementConfig;

        public void Init(IMovementConfig movementConfig)
        {
            currentMovementConfig = movementConfig;
        }

        public void MoveTowards(Vector3 direction, float deltaTime)
        {
            transform.Translate(direction * currentMovementConfig.Speed * deltaTime, Space.World);
        }

        public void RotateTowards(Vector3 direction, float deltaTime)
        {
            var targetRotation = Quaternion.LookRotation(Vector3.forward, direction.normalized);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, currentMovementConfig.RotationSpeed * deltaTime);
        }
    }
}