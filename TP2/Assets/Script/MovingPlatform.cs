using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _leftBound = -5f;
    [SerializeField] private float _rightBound = 5f;
    [SerializeField] private float _speed = 3f;

    private bool _movingRight = true;

    void Update()
    {
        if (_movingRight)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
            if (transform.position.x >= _rightBound)
            {
                _movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x <= _leftBound)
            {
                _movingRight = true;
            }
        }
    }
}
