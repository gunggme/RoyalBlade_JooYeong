using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPannel : MonoBehaviour
{
    [SerializeField] private int _highScore => PlayerPrefs.GetInt("HighScore");
    [SerializeField] private int _currentScore => _goodsManager.Gold;

    [Header("Texts")] 
    [SerializeField] private TMP_Text _highScoreText;
    [SerializeField] private TMP_Text _currentScoreText;
    
    private GoodsManager _goodsManager;

    private void Awake()
    {
        _goodsManager = FindObjectOfType<GoodsManager>();
    }

    private void OnEnable()
    {
        if (_highScore <= _currentScore)
        {
            PlayerPrefs.SetInt("HighScore", _currentScore);
        }
        
        _highScoreText.text = $"High Score\n{_highScore:N0}G";
        _currentScoreText.text = $"Score\n{_currentScore:N0}G";
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("InGame");
    }
}
