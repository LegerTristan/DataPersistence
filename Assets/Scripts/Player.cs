using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonTemplate<Player>
{

    Data playerData = new Data();

    public string Name { get; set; } = "David Goodenough";

    void OnEnable()
    {
        playerData.Load();
        DontDestroyOnLoad(gameObject);   
    }

    public int GetBestScore() => playerData.BestScore;

    public void SetBestScore(int _bestScore) => playerData.BestScore = _bestScore;

    public void SaveData() => playerData.Save();

}
