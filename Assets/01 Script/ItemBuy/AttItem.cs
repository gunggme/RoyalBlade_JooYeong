using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AttItem : ItemBase
{
    private Player _player;

    private void Awake()
    {
        _player = FindObjectOfType<Player>();
    }

    public override void BuyItem()
    {
        float upVal = Random.Range(_minUpVal, _maxUpVal);
        _player.AttPower += upVal;
    }
}
