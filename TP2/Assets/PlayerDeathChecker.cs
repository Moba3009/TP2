using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathChecker : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _deathThreshold = -5f;

    private void Update()
    {
        if (_player.position.y < transform.position.y + _deathThreshold)
        {
            Debug.Log("Le joueur est mort");
        }
    }
}
