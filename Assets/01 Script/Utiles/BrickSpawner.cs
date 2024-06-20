using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [SerializeField] private float _maxSpawnTimer;
    [SerializeField] private float _spawnTimer;
    [SerializeField] private float _totalTimer;

    [SerializeField] private GameObject _brickParentPrefab;
    private GameObject _remainObj;

    private void Update()
    {
        if (_spawnTimer >= _maxSpawnTimer)
        {
            SpawnBricks();
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
            _remainObj = PoolManager.SpawnObject(_brickParentPrefab, transform.position, Quaternion.identity);
            return;
        }
        if (!_remainObj.activeSelf)
        {
            _remainObj.gameObject.SetActive(true);
            return;
        }

        
    }
}
