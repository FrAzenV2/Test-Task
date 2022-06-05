using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Default Player Config", menuName = "Configs/Player", order = 0)]
    public class PlayerConfig : ScriptableObject, IMovementConfig
    {
        [field: SerializeField] public float Speed { get; private set; } = 10000;
        [field: SerializeField] public float RotationSpeed { get; private set; } = 0;
    }
}