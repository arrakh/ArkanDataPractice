using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemySpawnData[] allData;

    [SerializeField] private float randomSpawnDistance = 10f;
    //private Dictionary<string, EnemySpawnData> dataDictionary = new Dictionary<string, EnemySpawnData>(); 

    public void Spawn(string id)
    {
        EnemySpawnData data = FindData(id);
        var randPos = new Vector3(Random.Range(-randomSpawnDistance, randomSpawnDistance), 0f, Random.Range(-randomSpawnDistance, randomSpawnDistance));
        var gameObj = Instantiate(data.EnemyPrefabs, randPos, Quaternion.identity);
        var enemyController = gameObj.GetComponent<EnemyController>();
        enemyController.Initialize(data.CharacterStats);
    }

    private EnemySpawnData FindData(string id)
    {
        foreach (var data in allData)
        {
            if (data.ID == id) return data;
        }

        return null;
    }
}
