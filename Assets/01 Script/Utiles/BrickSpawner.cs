using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [SerializeField] private float _maxSpawnTimer;
    [SerializeField] private float _spawnTimer;

    private int _spawnIdx;
    
    [SerializeField] private GameObject _brickParentPrefab;
    private BrickParent _remainObj;

    private void Update()
    {
        if (_spawnTimer >= _maxSpawnTimer)
        {
            SpawnBricks();
            _remainObj.CurIdx = _spawnIdx;
            _spawnTimer = 0;
        }
        else
        {
            _spawnTimer += Time.deltaTime;
        }
    }

    void SpawnBricks()
    {
        
        if (_remainObj == null)
        {
            _spawnIdx++;
            _remainObj = PoolManager.SpawnObject(_brickParentPrefab, transform.position, Quaternion.identity).GetComponent<BrickParent>();
            return;
        }
        if (!_remainObj.gameObject.activeSelf)
        {
            _spawnIdx++;
            _remainObj.gameObject.SetActive(true);
            return;
        }

        
    }
}
