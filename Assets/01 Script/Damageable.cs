using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] private float _damage;
    public float Damage => _damage;
    [SerializeField] private float defencePower;

    [SerializeField] private GameObject _damageTextPrefab;

    private Canvas _canvas;

    private void Awake()
    {
        _canvas = GameObject.Find("UserCanvas").GetComponent<Canvas>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.CompareTag("Brick")){
            if (other.transform.parent.TryGetComponent(out BrickParent bp))
            {
                Debug.Log("올라감");
                DamageText textObj =
                    PoolManager.SpawnObject(_damageTextPrefab, transform.position, Quaternion.identity).GetComponent<DamageText>();
                textObj.transform.SetParent(_canvas.transform);
                textObj.transform.localScale = Vector3.one;
                textObj.SetText($"{_damage}");
                bp.UpForce(defencePower);
                gameObject.SetActive(false);
            }
        }
    }
}
