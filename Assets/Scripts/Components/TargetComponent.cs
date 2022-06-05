using Interfaces.ComponentInterfaces;
using UnityEngine;

namespace Components
{
    public class TargetComponent : MonoBehaviour, ITarget
    {
        public Transform Transform => transform;
    }
}