using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HPControllerBase : MonoBehaviour, IDeath, IHIt
{
    [SerializeField] protected float _maxHP;
    [SerializeField] protected float _curHP;

    public float MaxHp
    {
        get => _maxHP;
        set => _maxHP = value;
    }

    public float CurHp
    {
        get => _curHP;
        set => _curHP = value;
    }

    protected void OnEnable()
    {
        _curHP = _maxHP;
    }

    public abstract void Death();
    public abstract void Hit(float dmg);
}
