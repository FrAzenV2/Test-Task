using DataClasses;
using UnityEngine;

namespace Systems
{
    public static class SaveLoadSystem
    {
        private const string SaveKey = "SaveData";

        private static PlayerData data;

        public static PlayerData LoadPlayerData()
        {
            if (!PlayerPrefs.HasKey(SaveKey))
            {
                data = new PlayerData();
                PlayerPrefs.SetString(SaveKey, JsonUtility.ToJson(data));
                PlayerPrefs.Save();
            }

            data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString(SaveKey));
            return data;
        }

        public static void SavePlayerData()
        {
            PlayerPrefs.SetString(SaveKey, JsonUtility.ToJson(data));
            PlayerPrefs.Save();
        }

    }
}