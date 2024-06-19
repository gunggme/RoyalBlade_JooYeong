using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HPControllerBase : MonoBehaviour
{
    [SerializeField] private float _maxHP;
    [SerializeField] private float _curHP;

    public float MaxHp => _maxHP;
    public float CurHp => _curHP;
}
