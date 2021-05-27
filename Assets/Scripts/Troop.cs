using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : MonoBehaviour
{
    [SerializeField] private float _maxHitpoints;

    public float GetHitpoints()
    {
        return _maxHitpoints;
    }
}
