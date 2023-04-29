using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class HealthBar : MonoBehaviour
    {
        private HeroController _heroController;
        [SerializeField] private Slider _sliderHelth;
        [SerializeField] private float fillSpeed = 5f;
        


        private void Start()
        {
            _heroController = FindObjectOfType<HeroController>();
            _heroController.OnMaxHealthChanged += UpdateMaxHealth;
            _sliderHelth.maxValue = _heroController.MaxHealth;
            
        }

        private void Update()
        {
            _sliderHelth.value = _heroController.CurrentHealth;
            _sliderHelth.value = Mathf.Lerp(_sliderHelth.value, _heroController.CurrentHealth,  fillSpeed * Time.deltaTime);
        }
        
        private void UpdateMaxHealth(float newMaxHealth)
        {
            _sliderHelth.maxValue = newMaxHealth;
        }
    }
}