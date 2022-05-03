using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 8.0f, 0);
    }

    private float _speed = 4.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        // move down 4 meters per second
        // reach bottom and respawn at top
        // BONUS: respawn at random X position
    }
}
