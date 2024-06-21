using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BrickHPCon : HPControllerBase
{
    private GoodsManager _goodsManager;

    private void Awake()
    {
         _goodsManager = FindObjectOfType<GoodsManager>();
    }

    public override void Hit(float dmg)
    {
        _curHP -= dmg;
        Debug.Log($"{_curHP} 남음");
        if (_curHP <= 0)
        {
            Death();
            return;
        }

    }
    
    public override void Death()
    {
        _goodsManager.GetGold(Random.Range(Mathf.CeilToInt(_maxHP / 2), Mathf.CeilToInt(_maxHP)));
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Attack"))
        {
            if (other.TryGetComponent(out Damageable damageable))
            {
                Hit(damageable.Damage);
            }
        }
    }
}
