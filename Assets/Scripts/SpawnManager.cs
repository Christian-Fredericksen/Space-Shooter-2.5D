using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject _enemy;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
    }

    //spawn game object every 5 seconds
    //create a coroutine of type IEnumerator -- let's us use the YIELD key word so we can wait
    //       x# of seconds before moving on.
    //while loop

    IEnumerator SpawnRoutine()
    {

        //while loop (infinite loop)
        //instantiate enemy prefab
        //yield wait for 5 seconds

        float _randomX = Random.Range(-9f, 9f);
        while (true)
        {
            Instantiate(_enemy, new Vector3(_randomX, 5, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
