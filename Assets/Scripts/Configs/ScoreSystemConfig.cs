using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Default Score system config", menuName = "Configs/Systems/Score System", order = 0)]
    public class ScoreSystemConfig : ScriptableObject
    {
        [field: SerializeField] public float ScorePerSecond { get; private set; } = 1;
    }
}