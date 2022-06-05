using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreText;
        
        public void UpdateScore(float currentScore)
        {
            scoreText.text = ((int)currentScore).ToString();
        }
    }
}