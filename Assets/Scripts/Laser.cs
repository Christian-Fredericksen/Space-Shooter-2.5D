using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    // define a speed variable for this laser

    [SerializeField]
    private float _speed = 8.0f;

    void Start()
    {
     
    }

    // Update is called once per frame
    // translate this laser up
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        // if position is greater than 8 on the y axis
        // destroy laser
        if(transform.position.y > 6.0f)
        {
            Destroy(gameObject);
        }
    }
}
