using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField]
    private bool resetOnStart;

    [SerializeField]
    private FloatVariable _maxHP, _currentHP;

    private void OnEnable()
    {
        ResetHP();
    }

    private void OnDisable()
    {
        ResetHP();
    }

    private void ResetHP()
    {
        if (resetOnStart)
        {
        _currentHP.Value = _maxHP.Value;
        }
    }
}
