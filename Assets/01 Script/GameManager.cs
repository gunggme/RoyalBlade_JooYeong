using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public int RemainRound { get; set; }
    public int MaxRemainRound { get; set; }
    
    public bool GameStop { get; set; }

    public int TotalRound;

    [SerializeField] private GameObject _shopObj;

    [SerializeField] private TMP_Text _remainText;

    [SerializeField] private GameObject _gameOverPannel;

    [SerializeField] private GameObject _inGameButton;
    
    private void Awake()
    {
        MaxRemainRound = Random.Range(3, 6);

        _remainText.text = $"{RemainRound}/{MaxRemainRound}";
    }

    private void Start()
    {
        GameStop = true;
    }

    public void StartGame()
    {
        MaxRemainRound = Random.Range(3, 6);
        RemainRound = 0;
        GameStop = false;
    }

    public void MainStartGame()
    {
        StartGame();
        _inGameButton.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        _gameOverPannel.SetActive(true);    
    }

    public void UpdateRemain(int val)
    {
        RemainRound += val;
        TotalRound += val;
        _remainText.text = $"{RemainRound}/{MaxRemainRound}";
        if (RemainRound >= MaxRemainRound)
        {
            GameStop = true;
            _shopObj.SetActive(true);
            return;
        }
    }
}
