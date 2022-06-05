using DataClasses;
using Factories;
using UnityEngine;

namespace Systems
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private CockroachFactory cockroachFactory;
        [SerializeField] private int cockroachesAmount;
    
        public static GameManager Instance { get; private set; }
        public PlayerData PlayerData { get; private set; }
    
        private void StartGame()
        {
        
        }

        private void EndGame()
        {
            SaveLoadSystem.SavePlayerData();
        }
    
        private void Reload()
        {
        
        }

        private void Awake()
        {
            if (!Instance) Instance = this;
            else
            {
                Destroy(this);
            }
        }

        private void Start()
        {
            PlayerData = SaveLoadSystem.LoadPlayerData();
        }
    }
}