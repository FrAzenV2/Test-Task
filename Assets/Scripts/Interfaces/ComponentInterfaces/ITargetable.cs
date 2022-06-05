using UnityEngine;

namespace Interfaces.ComponentInterfaces
{
    public interface ITargetable
    {
        void SetTarget(ITarget target);
        
        Transform CurrentTargetTransform { get; }
        Vector3 DirectionToTargetPos { get; }
    }
}