using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] protected int _price;
    [SerializeField] protected float _maxUpVal;
    [SerializeField] protected float _minUpVal;

    [SerializeField] private TMP_Text _priceText;

    [SerializeField] protected GameObject _shopParent;
    
    protected GameManager _gameManager;
    protected GoodsManager _goodsManager;

    protected virtual void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _goodsManager = FindObjectOfType<GoodsManager>();
    }

    protected void OnEnable()
    {
        _price = (_goodsManager.Gold + (100 * _gameManager.TotalRound / Random.Range(45, 60)));
        _priceText.text = $"{_price:N0}G";
    }

    public abstract void BuyItem();
}
