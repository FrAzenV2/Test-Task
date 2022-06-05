using TMPro;
using UnityEngine;

namespace UI
{
    public class StartScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text currentBestText;
        [SerializeField] private string currentBestPrefix = "CURRENT BEST:\n";

        public void ShowCurrentBest(int currentBest)
        {
            currentBestText.text = currentBestPrefix + currentBest;
        }
    }
}