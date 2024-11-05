using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _platformPrefab;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private float _platformLifetime = 10f;
    [SerializeField] private float _horizontalRange = 5f;
    [SerializeField] private float _initialY = 0f;
    [SerializeField] private float _yIncrement = 3f;

    private float _currentY;

    private void Start()
    {
        _currentY = _initialY;
        StartCoroutine(SpawnPlatforms());
    }

    private IEnumerator SpawnPlatforms()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnInterval);
            Vector2 spawnPosition = new Vector2(Random.Range(-_horizontalRange, _horizontalRange), _currentY);
            GameObject newPlatform = Instantiate(_platformPrefab, spawnPosition, Quaternion.identity);
            Destroy(newPlatform, _platformLifetime);
            _currentY += _yIncrement;
        }
    }
}
