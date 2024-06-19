using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HPControllerBase : MonoBehaviour, IDeath, IHIt
{
    [SerializeField] protected float _maxHP;
    [SerializeField] protected float _curHP;

    public float MaxHp => _maxHP;
    public float CurHp => _curHP;

    protected void OnEnable()
    {
        _curHP = _maxHP;
    }

    public abstract void Death();
    public abstract void Hit(float dmg);
}