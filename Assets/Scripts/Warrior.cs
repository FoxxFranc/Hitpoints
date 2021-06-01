using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour 
{
    [SerializeField] private float _maxHitpoints;
    [SerializeField]  private float _currentHitpoints;

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

    public void TakeHeal(float healValue)
    {
        _currentHitpoints += healValue;
    }
}
