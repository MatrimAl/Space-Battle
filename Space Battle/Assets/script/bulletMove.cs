using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float speed = 15.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    
    void Update()
    {
        if (transform.position.y < -6)
        {

            Destroy(this.gameObject);
        }
    }
}
