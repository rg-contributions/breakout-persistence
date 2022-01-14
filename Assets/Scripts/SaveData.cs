using System.IO;
using UnityEngine;

class DataSaver
{
	[System.Serializable]
	class SaveData
	{
		public string currentHiScorePlayer;
		public int currentHiScore;
	}

	static public void Save()
	{
        SaveData data = new SaveData();
        data.currentHiScore = DataKeeper.Instance.currentHiScore;
		data.currentHiScorePlayer = DataKeeper.Instance.currentHiScorePlayer;
		
		string json = JsonUtility.ToJson(data);
		File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
	}

	static public void Load()
	{
		string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            DataKeeper.Instance.currentHiScore = data.currentHiScore;
            DataKeeper.Instance.currentHiScorePlayer = data.currentHiScorePlayer;
        }

	}
}

