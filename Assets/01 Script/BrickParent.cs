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
                bhp.MaxHp = Mathf.RoundToInt( 20 + (CurIdx * 10));
                bhp.CurHp = bhp.MaxHp;
            }
            brick.transform.SetParent(transform);
        }
    }

    public void UpForce(float power)
    {
        int remainBrick = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                remainBrick++;
            }
        }

        if (remainBrick == transform.childCount)
        {
            gameObject.SetActive(false);
        }
        _rigid.velocity = Vector3.zero;
        _rigid.AddForce(Vector3.up * power, ForceMode2D.Impulse);
    }
}
