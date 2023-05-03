using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move down at a speed of 3 (adjust in the inspector)
        // When we leave the screen destroy this object
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -6.8f) 
        {
            Destroy(gameObject);
        }
                
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.TripleShotActivate();
            }
            Destroy(gameObject);

        }
    }
    // OnTriggerCollision
    // Only be collectable by the player (HINT: Use tags)
    // On collected destroy
}
