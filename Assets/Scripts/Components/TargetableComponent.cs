using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Components
{
    public class TargetableComponent : MonoBehaviour, ITargetable
    {
        private ITarget currentTarget;

        public void SetTarget(ITarget target)
        {
            currentTarget = target;
        }
        public Transform CurrentTargetTransform => currentTarget.Transform;
        public Vector3 DirectionToTargetPos => (CurrentTargetTransform.position - transform.position).normalized;
    }
}