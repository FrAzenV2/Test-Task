using Configs;
using UI;
using UnityEngine;

namespace Systems
{
    public class ScoreSystem : MonoBehaviour
    {
        [SerializeField] private ScoreSystemConfig systemConfig;
        [SerializeField] private ScoreScreen scoreScreen;

        public float CurrentScore { get; private set; } = 0;

        private bool canScore;

        public void StartScoring()
        {
            canScore = true;
            scoreScreen.gameObject.SetActive(true);
        }

        public void StopScoring()
        {
            canScore = false;
            scoreScreen.gameObject.SetActive(true);
        }

        private void Update()
        {
            if (!canScore) return;

            CurrentScore += Time.deltaTime * systemConfig.ScorePerSecond;
            scoreScreen.UpdateScore(CurrentScore);
        }
    }
}