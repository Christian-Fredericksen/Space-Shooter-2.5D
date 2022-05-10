using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField]
    private float _speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        
        if (transform.position.y <= -7.0f)
        {
            float randomX = Random.Range(-9.3f, 9.3f);
            transform.position = new Vector3(randomX, 8.0f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if other is Player
        if (other.tag == "Player")
        //damage player
        //destroy us
        {
            Destroy(this.gameObject);
        }

        //if other is laser
        else if (other.tag == "Laser")
        {
            //destroy laser
            Destroy(other.gameObject);
            //destroy us
            Destroy(this.gameObject);
        }
    }
}
