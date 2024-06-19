using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private float _damage;
    public float Damage => _damage;
    [SerializeField] private float defencePower;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.CompareTag("Brick")){
            if (other.transform.parent.TryGetComponent(out BrickParent bp))
            {
                Debug.Log("올라감");
                bp.UpForce(defencePower);
                gameObject.SetActive(false);
            }
        }
    }
}
