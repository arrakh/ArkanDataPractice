using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerPrefsTest : MonoBehaviour
    {
        [SerializeField] private int highscore = 100;
        [SerializeField] private string username;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                var key = username + "-highscore";
                PlayerPrefs.SetInt(key, highscore);
                Debug.Log($"Saved {username} score to {highscore}");
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                var key = username + "-highscore";
                int score = PlayerPrefs.GetInt(key, 0);
                Debug.Log($"Score {username} adalah {score}");
            }
        }
    }
}