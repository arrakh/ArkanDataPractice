using System;
using System.IO;
using UnityEngine;

namespace DefaultNamespace
{
    public class FileSaveTest : MonoBehaviour
    {
        [SerializeField] private int highscore = 100;
        [SerializeField] private string username;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                File.WriteAllText($"C:/SaveFile/{username}.txt", highscore.ToString());
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                if (!File.Exists($"C:/SaveFile/{username}.txt")) return;
                var saveFile = File.ReadAllText($"C:/SaveFile/{username}.txt");
                var total = int.Parse(saveFile) + 10;
                Debug.Log(total);
            }
        }
    }
}