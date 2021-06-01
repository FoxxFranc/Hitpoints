using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitpointsBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;
    [SerializeField] private Warrior _warrior;

    private void Start()
    {
        _slider.maxValue = _warrior.MaxHitpoints;
        _slider.value = _warrior.CurrentHitpoints;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _warrior.CurrentHitpoints, _speed * Time.deltaTime);
    }
}
