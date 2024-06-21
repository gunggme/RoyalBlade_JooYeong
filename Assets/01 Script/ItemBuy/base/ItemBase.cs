using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] protected int _price;
    [SerializeField] protected float _maxUpVal;
    [SerializeField] protected float _minUpVal;

    [SerializeField] private TMP_Text _priceText;
    
    protected GameManager _gameManager;
    protected GoodsManager _goodsManager;

    protected virtual void Awake()
    {
        _goodsManager = FindObjectOfType<GoodsManager>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    protected void OnEnable()
    {
        _priceText.text = $"{_price:N0}G";
    }

    public abstract void BuyItem();
}
