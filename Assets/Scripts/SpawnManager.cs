using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private GameObject _enemyContainer;

    private bool _stopSpawning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRoutine()
    {
        Vector3 spawnX = new Vector3(Random.Range(-9f, 9f), 6.5f, 0);
        while (_stopSpawning == false)
        {
            GameObject _newEnemy = Instantiate(_enemyPrefab, spawnX , Quaternion.identity);
            _newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);
        }
    }
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }

}
