using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpDown : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _playerHP;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("triggerworks");
            _playerHP.Value -= 5;
        }
    }
}
