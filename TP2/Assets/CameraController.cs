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
        // La cam�ra monte de fa�on constante
        transform.position += new Vector3(0, _verticalSpeed * Time.deltaTime, 0);

        // V�rifie si le joueur est au-dessus de la cam�ra
        if (_player.position.y > transform.position.y + _followThreshold)
        {
            transform.position = new Vector3(transform.position.x, _player.position.y - _followThreshold, transform.position.z);
        }
    }
}
