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

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        
    }

    private void OnEnable()
    {
        int ranIdx = Random.Range(3, 6);
        for (int i = 0; i < ranIdx; i++)
        {
            GameObject brick = PoolManager.Instantiate(_brickPrefabs, transform.position + (_brickOffset * i), quaternion.identity);
            brick.transform.SetParent(transform);
        }
    }

    public void UpForce(float power)
    {
        _rigid.AddForce(Vector3.up * power, ForceMode2D.Impulse);
    }
}
