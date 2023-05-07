using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _tripleShotPowerupPrefab;
    [SerializeField]
    private GameObject _enemyContainer;

    private bool _stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
        StartCoroutine(SpawnPowerupRoutine());
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (_stopSpawning == false)
        {
            Vector3 spawnX = new Vector3(Random.Range(-9.0f, 9.0f), 6.5f, 0);
            GameObject _newEnemy = Instantiate(_enemyPrefab, spawnX , Quaternion.identity);
            _newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);
        }
    }

    IEnumerator SpawnPowerupRoutine()
    {
        while (_stopSpawning == false)
        {
            Vector3 randoX = new Vector3(Random.Range(-9.0f, 9.0f), 6.5f, 0);
            Instantiate(_tripleShotPowerupPrefab, randoX, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3, 8));
        }
        
    }
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }

}