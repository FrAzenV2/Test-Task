using System;
using Interfaces.ComponentInterfaces;
using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        private IMovable movementComponent;
        private ITargetable targetableComponent;

        public void Init(IMovementConfig movementConfig,ITarget target)
        {
            movementComponent.Init(movementConfig);
            targetableComponent.SetTarget(target);
        }
        
        private void Update()
        {
            movementComponent.MoveTowards(targetableComponent.CurrentTargetTransform.position, Time.deltaTime);
        }

        private void Awake()
        {
            movementComponent = GetComponent<IMovable>();
            targetableComponent = GetComponent<ITargetable>();
        }
    }
}