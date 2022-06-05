using UnityEngine;

namespace Interfaces.ComponentInterfaces
{
    public interface ITargetable
    {
        void SetTargetPosition(Vector3 pos);
        
        Vector3 CurrentTargetPos { get; }
        Vector3 DirectionToTargetPos { get; }
    }
}