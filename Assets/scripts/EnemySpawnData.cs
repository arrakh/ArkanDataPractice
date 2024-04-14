using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySpawnData", menuName = "Enemy Spawn Data")]
public class EnemySpawnData : UnityEngine.ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private GameObject enemyPrefabs;
    [SerializeField] private CharacterStats characterStats;

    public CharacterStats CharacterStats => characterStats;

    public GameObject EnemyPrefabs => enemyPrefabs;

    public string ID => id;
}
