using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DefItem : ItemBase
{
    private Player _player;

    protected override void Awake()
    {
        base.Awake();
        _player = FindObjectOfType<Player>();
    }

    public override void BuyItem()
    {
        if (_goodsManager.UseGold(_price))
        {
            float upVal = Random.Range(_minUpVal, _maxUpVal);
            _player.MaxDeffenceTime *= upVal;
            _gameManager.StartGame();
            _shopParent.gameObject.SetActive(false);
        }
        
    }
}
