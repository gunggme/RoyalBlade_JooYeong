using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickHPCon : HPControllerBase
{
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
