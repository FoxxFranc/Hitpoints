using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour //Класс игрока, в котором записана информация о его текущем ХП и максимальном количестве ХП.
{
    [SerializeField] private float _maxHitpoints;

    private float _currentHitpoints;

    public float MaxHitpoints => _maxHitpoints;
    public float CurrentHitpoints => _currentHitpoints;

    private void Start()
    {
        _currentHitpoints = _maxHitpoints;
    }

    public void TakeDamage(float damage)
    {
        _currentHitpoints -= damage;
    }

    public void TakeHealwave(float healValue)
    {
        _currentHitpoints += healValue;
    }
}
