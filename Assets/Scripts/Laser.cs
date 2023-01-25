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
    }
}
