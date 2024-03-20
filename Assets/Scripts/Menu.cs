using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    const string DEFAULT_NAME = "David Goodenough";

    [SerializeField]
    Text txtBestScore = null;

    [SerializeField]
    InputField inputFieldName= null;

    [SerializeField]
    Button btnStart = null;

    [SerializeField]
    Button btnQuit = null;

    Player player = null;

    bool IsMenuValid => txtBestScore && inputFieldName && btnStart && btnQuit;


    void Start()
    {
        if (!IsMenuValid)
            return;

        inputFieldName.onValueChanged.AddListener(UpdatePlayerName);
        btnStart.onClick.AddListener(LoadLevel);
        btnQuit.onClick.AddListener(() => Application.Quit());
        UpdatePlayerName(DEFAULT_NAME);
        UpdateScore();
    }

    private void UpdateScore()
    {
        player = Player.Instance;
        if (player)
        {
            txtBestScore.text = $"Best Score : {player.GetBestScore()}";
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene("main");
    }

    void UpdatePlayerName(string _value)
    {
        player = Player.Instance;
        if (player)
            player.Name = _value;
    }
}
