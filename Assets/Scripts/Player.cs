using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    //Set a private speed variable
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    
    void Start()
    {
        //Define a starting position.
        //Take the current position & make it = to new position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    
    void Update()
    {
        calculateMovement();

        //If I hit the space bar
        //spawn a new laser

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = new Vector3(0, .8f, 0);
            Instantiate(_laserPrefab, transform.position + offset, Quaternion.identity);
        }

    }

    void calculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.8f)
        {
            transform.position = new Vector3(transform.position.x, -4.8f, 0);
        }

        if (transform.position.x > 11.25f)
        {
            transform.position = new Vector3(-11.25f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.25f)
        {
            transform.position = new Vector3(11.25f, transform.position.y, 0);
        }
    }
}
