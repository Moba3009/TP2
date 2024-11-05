using System.Collections;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pointCollectablePrefab;
    [SerializeField] private GameObject _bonusCollectablePrefab;
    [SerializeField] private GameObject _bonusZonePrefab;

    [SerializeField] private float _spawnInterval = 5f;      
    [SerializeField] private float _spawnRadius = 10f;     
    [SerializeField] private int _maxCollectables = 10;     

    private int _currentCollectables = 0;  

    private void Start()
    {
        StartCoroutine(SpawnCollectables());
    }

    private IEnumerator SpawnCollectables()
    {
        while (true)
        {
            if (_currentCollectables < _maxCollectables)
            {
               
                int randomChoice = Random.Range(0, 3);

                GameObject prefabToSpawn = null;
                switch (randomChoice)
                {
                    case 0:
                        prefabToSpawn = _pointCollectablePrefab;
                        break;
                    case 1:
                        prefabToSpawn = _bonusCollectablePrefab;
                        break;
                    case 2:
                        prefabToSpawn = _bonusZonePrefab;
                        break;
                }

                
                Vector2 spawnPosition = (Vector2)transform.position + Random.insideUnitCircle * _spawnRadius;

             
                Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
                _currentCollectables++;
            }

            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
