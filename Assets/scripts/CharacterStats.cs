using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "New Stats", menuName = "Character Stats")]

    public class CharacterStats : UnityEngine.ScriptableObject
    {
        [SerializeField] private int maxHealth;
        [SerializeField] private int stamina;
        [SerializeField] private int mana;

        public int Mana => mana;

        public int Stamina => stamina;

        public int MaxHealth => maxHealth;
    }
}