using System;
using UnityEditorInternal;
using UnityEngine;

namespace DefaultNamespace
{
    public class HeroController : MonoBehaviour
    {
        [SerializeField] private float _maxHealth = 100f;
        [SerializeField] private float _currentHealth = 100f;
        public float MaxHealth { get; private set; } 
        public float CurrentHealth { get; set; }
        public event Action<float> OnMaxHealthChanged;


        private void Start()
        {
            MaxHealth = _maxHealth;
            CurrentHealth = _currentHealth;
            OnMaxHealthChanged?.Invoke(MaxHealth);
        }
        
    }
    
    
}