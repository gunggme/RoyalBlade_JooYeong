using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipItem : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField] private GameObject _shopParent;
    
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void BuySkip()
    {
        _gameManager.StartGame();
        _shopParent.gameObject.SetActive(false);
    }
}
