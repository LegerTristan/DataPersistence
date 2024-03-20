using System.IO;
using UnityEngine;


[System.Serializable]
public class Data
{
    const string JSON_FILE = "Save.json";

    public int BestScore = 0;

    public void Save()
    {
        string _json = JsonUtility.ToJson(this);
        File.WriteAllText(Application.persistentDataPath + JSON_FILE, _json);
    }

    public void Load()
    {
        string _path = Application.persistentDataPath + JSON_FILE;
        if (File.Exists(_path))
        {
            string _json = File.ReadAllText(_path);
            Data _savedData = JsonUtility.FromJson<Data>(_json);
            BestScore = _savedData.BestScore;
        }
    }
}
