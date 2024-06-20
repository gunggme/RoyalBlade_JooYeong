using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;

public class PoolManager : MonoBehaviour
{
    public static List<PoolObjectInfo> ObjectPools = new List<PoolObjectInfo>();

    [CanBeNull] private GameObject _objectPoolEmptyHolder;

    private static GameObject _particleSystemEmpty;
    private static GameObject _gameObjectEmpty;

    public enum PoolType
    {
        ParticleSystem,
        GameObject,
        None
    }

    public static PoolType PoolingType;

    private void Awake()
    {
        SetupEmpties();
    }

    void SetupEmpties()
    {
        _objectPoolEmptyHolder = new GameObject("Pooled Objects");

        _particleSystemEmpty = new GameObject("Particle Effects");
        _particleSystemEmpty.transform.SetParent(_objectPoolEmptyHolder.transform);

        _gameObjectEmpty = new GameObject("GamaeObjects");
        _gameObjectEmpty.transform.SetParent(_objectPoolEmptyHolder.transform);
    }


    public static GameObject SpawnObject(GameObject objectToSpawn, Vector3 spawnPos, Quaternion spawnQuaternion, PoolType poolType = PoolType.None)
    {
        PoolObjectInfo pool = ObjectPools.Find(p => p.LookupString == objectToSpawn.name);
    
        if (pool == null)
        {
            pool = new PoolObjectInfo() { LookupString = objectToSpawn.name };
            ObjectPools.Add(pool);
        }
    
        GameObject spawnableObj = pool.InactiveObjects.FirstOrDefault();

        if (spawnableObj == null)
        {
            GameObject parentObject = SetParentObject(poolType);
            
            spawnableObj = Instantiate(objectToSpawn, spawnPos, spawnQuaternion);
            if (parentObject ! != null)
            {
                spawnableObj.transform.SetParent(parentObject.transform);
            }
        }
        else
        {
            spawnableObj.transform.position = spawnPos;
            spawnableObj.transform.rotation = spawnQuaternion;
            pool.InactiveObjects.Remove(spawnableObj);
        }

        return spawnableObj;
    }

    public static void ReturnObjectPool(GameObject obj)
    {
        string goName = obj.name.Substring(0, obj.name.Length - 7);
        
        PoolObjectInfo pool = ObjectPools.Find(q => q.LookupString == obj.name);

        if (pool == null)
        {
            Debug.LogWarning($"Trying to release an object that is not pooled : {obj.name}");
        }
        else
        {
            obj.SetActive(false);
        }
    }

    public static GameObject SetParentObject(PoolType poolType)
    {
        switch (poolType)
        {
            case PoolType.ParticleSystem:
                return _particleSystemEmpty;
            case PoolType.GameObject:
                return _gameObjectEmpty;
            case PoolType.None:
                return null;
            default:
                return null;
        }
    }
}
public class PoolObjectInfo
{
    public string LookupString;
    public List<GameObject> InactiveObjects = new List<GameObject>();
}