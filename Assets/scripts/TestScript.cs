using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField] private EnemySpawner spawner;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                spawner.Spawn("Skeleton");
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                spawner.Spawn("Zombie");
            }
            
            if (Input.GetKeyDown(KeyCode.D))
            {
                spawner.Spawn("MutantZombie");
            }
        }
    }
}