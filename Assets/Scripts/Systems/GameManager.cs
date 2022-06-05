using System.Collections.Generic;
using Components;
using Configs;
using DataClasses;
using Entities;
using Factories;
using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Systems
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private PlayerConfig playerConfig;
        [SerializeField] private MouseFollowerComponent playerTarget;

        [SerializeField] private CockroachFactory cockroachFactory;
        [SerializeField] private int cockroachesAmount = 1;
        [SerializeField] private FinishComponent finishComponent;

        [SerializeField] private ScoreSystem scoreSystem;
        [SerializeField] private FinalScreen finalScreen;
        public static GameManager Instance { get; private set; }
        public PlayerData PlayerData { get; private set; }

        private readonly List<Cockroach> aliveCockroaches = new();

        public void StartGame()
        {
            player.gameObject.SetActive(true);
            player.Init(playerConfig, playerTarget);

            for (var i = 0; i < cockroachesAmount; i++) aliveCockroaches.Add(cockroachFactory.CreateCockroach(finishComponent));

            scoreSystem.StartScoring();
        }

        public void EndGame()
        {
            scoreSystem.StopScoring();

            //Disable cockroaches on background
            foreach (var cockroach in aliveCockroaches) cockroach.enabled = false;

            player.enabled = false;

            var gameScore = (int)scoreSystem.CurrentScore;
            var previousBest = PlayerData.HighScore;

            var newBest = gameScore > previousBest;

            if (newBest) PlayerData.HighScore = gameScore;

            finalScreen.Open(previousBest, gameScore, newBest);

            SaveLoadSystem.SavePlayerData();
        }

        public void Restart()
        {
            SaveLoadSystem.SavePlayerData();
            Reload();
        }

        public void CloseGame()
        {
            SaveLoadSystem.SavePlayerData();
            Application.Quit();
        }

        private void Reload()
        {
            Destroy(Instance.gameObject);
            SceneManager.LoadScene(0);
        }

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            PlayerData = SaveLoadSystem.LoadPlayerData();
        }
    }
}