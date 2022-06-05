using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private string scorePrefix = "SCORE: ";
        public void UpdateScore(float currentScore)
        {
            scoreText.text = scorePrefix + (int)currentScore;
        }
    }
}