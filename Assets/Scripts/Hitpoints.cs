using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitpoints : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _damage;
    [SerializeField] private float _healValue;
    [SerializeField] private float _speed;
    [SerializeField] private Player _player;

    private void Start()
    {
        _slider.maxValue = _player.MaxHitpoints;
        _slider.value = _player.CurrentHitpoints;
    }

    private IEnumerator ChangeValue()
    {
        while (_player.CurrentHitpoints != _slider.value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.CurrentHitpoints, _speed * Time.deltaTime);
            yield return _speed * Time.deltaTime;
        }
    }

    public void TakeDammage()
    {
        _player.TakeDamage(_damage);
        StartCoroutine(ChangeValue());
    }

    public void Heal()
    {
        _player.TakeHealwave(_healValue);
        StartCoroutine(ChangeValue());
    }
}
