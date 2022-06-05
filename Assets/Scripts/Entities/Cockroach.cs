using Configs;
using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Entities
{
    public class Cockroach : MonoBehaviour
    {
        private IMovable movementComponent;
        private IScarable scareComponent;
        private ITargetable targetableComponent;

        private CockroachConfig entityConfig;
        private Vector3 currentDirection;
        
        public void Init(CockroachConfig config, ITarget target)
        {
            entityConfig = config;
            movementComponent = GetComponent<IMovable>();
            scareComponent = GetComponent<IScarable>();
            targetableComponent = GetComponent<ITargetable>();
            
            movementComponent.Init(config);
            targetableComponent.SetTarget(target);
        }

        private void Update()
        {
            CalculateCurrentMoveDirection();
            Move();
        }
        
        private void Move()
        {
            movementComponent.MoveTowards(currentDirection, Time.deltaTime);
            movementComponent.RotateTowards(currentDirection, Time.deltaTime);
        }
        
        private void CalculateCurrentMoveDirection()
        {
            var currentTargetDirection = targetableComponent.DirectionToTargetPos;
            var currentScareAmount = scareComponent.ScareAmount;
            var currentScareAwayDirection = (scareComponent.LastScareEpicenter - transform.position).normalized;

            // If we not much scared we can still go in general direction of our target;
            var newDirection = Vector3.Lerp(currentTargetDirection, currentScareAwayDirection, currentScareAmount); 
            //If we want we also can take in equation our previous direction;
            currentDirection = Vector3.Lerp(currentDirection, newDirection, entityConfig.NewDirectionAffect);
        }
    }
}