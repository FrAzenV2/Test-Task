using TMPro;
using UnityEngine;

namespace UI
{
    public class FinalScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text highScoreText;
        [SerializeField] private string highScorePrefix = "Highscore: ";
        [SerializeField] private TMP_Text currentScoreText;
        [SerializeField] private string currentScorePrefix = "Current Score: ";
        [SerializeField] private TMP_Text newHighScoreText;

        public void Open(int highScore, int currentScore, bool isNewHighScore)
        {
            highScoreText.text = highScorePrefix + highScore;
            currentScoreText.text = currentScorePrefix + currentScore;
            if (isNewHighScore) newHighScoreText.gameObject.SetActive(true);
        }
    }
}