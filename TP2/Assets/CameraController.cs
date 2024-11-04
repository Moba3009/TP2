using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _verticalSpeed = 2f;
    [SerializeField] private float _followThreshold = 1f;

    private void Update()
    {
        // La caméra monte de façon constante
        transform.position += new Vector3(0, _verticalSpeed * Time.deltaTime, 0);

        // Vérifie si le joueur est au-dessus de la caméra
        if (_player.position.y > transform.position.y + _followThreshold)
        {
            transform.position = new Vector3(transform.position.x, _player.position.y - _followThreshold, transform.position.z);
        }
    }
}
