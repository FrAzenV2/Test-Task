using System.Collections.Generic;
using Components;
using Configs;
using DataClasses;
using Entities;
using Factories;
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
    
        public static GameManager Instance { get; private set; }
        public PlayerData PlayerData { get; private set; }

        private List<Cockroach> aliveCockroaches = new List<Cockroach>();

        public void StartGame()
        {
            player.gameObject.SetActive(true);
            player.Init(playerConfig, playerTarget);

            for (int i = 0; i < cockroachesAmount; i++)
            {
                aliveCockroaches.Add(cockroachFactory.CreateCockroach(finishComponent));
            }
        }

        public void EndGame()
        {
            foreach (var cockroach in aliveCockroaches)
            {
                cockroach.enabled = false;
            }
            player.enabled = false;
            SaveLoadSystem.SavePlayerData();
        }

        public void Restart()
        {
            SaveLoadSystem.SavePlayerData();
            Reload();
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