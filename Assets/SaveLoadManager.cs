using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    string filePath;
    TestSript GM;

    private void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "save.gamesave");
        GM = GetComponent<TestSript>();
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Create);

        Save save = new Save();

        save.Score = GM.number;

        bf.Serialize(fs, save);
        fs.Close();

    }

    public void LoadGame()
    {
        if (!File.Exists(filePath)) return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Open);

        Save save = (Save)bf.Deserialize(fs);
        fs.Close();

        GM.number = save.Score;
        GM.text.text = GM.number.ToString();
    }
}

[System.Serializable]
public class Save
{
    public int Score;
}
