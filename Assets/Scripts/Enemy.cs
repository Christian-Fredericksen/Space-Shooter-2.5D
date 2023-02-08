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
    private float _speed = 4.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -6.55f)
        {
            float randomX = Random.Range(-9f, 9f);
            transform.position = new Vector3(randomX, 6.56f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //If 'other' is Player
        //Damage Player
        //Destroy Enemy

        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                player.damage();
            }

            Destroy(gameObject);
        }

        //elseIf 'other is Laser
          //Destroy Laser
          //then Destroy Enemy

        else if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }



}
