using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BrickParent : MonoBehaviour
{
    [SerializeField] private GameObject _brickPrefabs;
    [SerializeField] private Vector3 _brickOffset;
    
    private Rigidbody2D _rigid;

    public int CurIdx
    {
        get;
        set;
    }

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        
    }

    private void OnEnable()
    {
        int ranIdx = Random.Range(3, 6);
        for (int i = 0; i < ranIdx; i++)
        {
            GameObject brick = PoolManager.SpawnObject(_brickPrefabs, transform.position + (_brickOffset * i), quaternion.identity);
            if (brick.TryGetComponent(out BrickHPCon bhp))
            {
                bhp.CurHp = bhp.MaxHp + (CurIdx * 10);
            }
            brick.transform.SetParent(transform);
        }
    }

    public void UpForce(float power)
    {
        if (transform.childCount == 0)
        {
            gameObject.SetActive(false);
            return;
        }
        _rigid.velocity = Vector3.zero;
        _rigid.AddForce(Vector3.up * power, ForceMode2D.Impulse);
    }
}
