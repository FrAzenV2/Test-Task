using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Components
{
    public class PlayerMovementComponent : MonoBehaviour, IMovable
    {
        private IMovementConfig currentMovementConfig;
        public void Init(IMovementConfig movementConfig)
        {
            currentMovementConfig = movementConfig;
        }
        public void MoveTowards(Vector3 point, float deltaTime)
        {
            transform.position = Vector3.MoveTowards(transform.position, point, currentMovementConfig.Speed * deltaTime);
        }
        public void RotateTowards(Vector3 direction, float deltaTime)
        {

        }
    }
}