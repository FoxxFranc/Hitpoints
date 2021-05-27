using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitpoints : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _dammage;
    [SerializeField] private float _healValue;
    [SerializeField] private float _speed;
    [SerializeField] private Troop _troop;

    private float _currentValue;

    private void Start()
    {
        _slider.maxValue = _troop.GetHitpoints();
        _slider.value = _slider.maxValue;
        _currentValue = _slider.value;
    }

    private IEnumerator ChangeValue()
    {
        while (_currentValue != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _currentValue, _speed * Time.deltaTime);
            yield return _speed * Time.deltaTime;
        }
    }

    public void TakeDammage()
    {
        _currentValue -= _dammage;
        StartCoroutine(ChangeValue());
    }

    public void Heal()
    {
        _currentValue += _healValue;
        StartCoroutine(ChangeValue());
    }
}
