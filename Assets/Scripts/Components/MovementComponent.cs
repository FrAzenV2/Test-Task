using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Components
{
    public class MovementComponent : MonoBehaviour, IMovable
    {
        private IMovementConfig currentMovementConfig;

        public void Init(IMovementConfig movementConfig)
        {
            currentMovementConfig = movementConfig;
        }
        
        public void MoveTowards(Vector3 direction, float deltaTime)
        {
            transform.Translate(direction * currentMovementConfig.Speed * deltaTime);
        }
       
        public void RotateTowards(Vector3 direction, float deltaTime)
        {
            var targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, currentMovementConfig.RotationSpeed * deltaTime);
        }
    }
}