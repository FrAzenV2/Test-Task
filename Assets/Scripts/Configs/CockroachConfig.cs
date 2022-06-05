using Interfaces.ConfigInterfaces;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Default Cockroach Config", menuName = "Configs/Entity Config", order = 0)]
    public class CockroachConfig : ScriptableObject, IMovementConfig
    {
        [field: SerializeField] public float Speed { get; private set; } = 3;
        [field: SerializeField] public float RotationSpeed { get; private set; } = 270;
        [field: SerializeField] public float NewDirectionAffect { get; private set; } = 0.8f;
    }
}