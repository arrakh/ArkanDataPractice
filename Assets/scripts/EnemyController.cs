using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private CharacterStats characterStats;
    [SerializeField] private int currentHealth;


    public void Initialize(CharacterStats stats)
    {
        characterStats = stats;
        currentHealth = characterStats.MaxHealth;
    }

    public void Damage()
    {
        currentHealth -= 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage();
        }
    }
}
