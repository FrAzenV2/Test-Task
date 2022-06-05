using TMPro;
using UnityEngine;

namespace UI
{
    public class FinalScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text highScoreText;
        [SerializeField] private string highScorePrefix = "Highscore:n";
        [SerializeField] private TMP_Text currentScoreText;
        [SerializeField] private string currentScorePrefix = "Current Score: ";
        [SerializeField] private GameObject newHighScoreLabel;

        public void Open(int highScore, int currentScore, bool isNewHighScore)
        {
            gameObject.SetActive(true);
            highScoreText.text = highScorePrefix + highScore;
            currentScoreText.text = currentScorePrefix + currentScore;
            if (isNewHighScore) newHighScoreLabel.SetActive(true);
        }
    }
}