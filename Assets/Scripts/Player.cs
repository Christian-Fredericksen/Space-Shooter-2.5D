using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }



    void Update()
    {
        CalculateMovement();

        //if i hit the space key
        //spawn a laser

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab, transform.position, Quaternion.identity);          
        }

    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);
        // VERTICAL LIMITS

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -4.8f)
        {
            transform.position = new Vector3(transform.position.x, -4.8f, 0);
        }
        // HORIZONTAL LIMITS
        if (transform.position.x <= -9.3f)
        {
            transform.position = new Vector3(-9.3f, transform.position.y, 0);
        }
        else if (transform.position.x >= 9.3f)
        {
            transform.position = new Vector3(9.3f, transform.position.y, 0);
        }
    }
}


//  WRAP PLAYER AROUND SCREEN BOTH DIRECTIONS
//If player position on the x axis is >= 12
// reset position to -11.25
// else if player position on the x axis is <= -12
// reset position to 11.25

// if (transform.position.x >= 12) 
// {
//     transform.position = new Vector3(-11.25f, transform.position.y, 0);
// }
// else if(transform.position.x <= -12)
// {
//     transform.position = new Vector3(11.25f, transform.position.y, 0);
// }
