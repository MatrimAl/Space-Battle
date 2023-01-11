using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bulletMove : MonoBehaviour
{
    public float speed = 15.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    
    void Update()
    {
        if (transform.position.y < -6)
        {

            Destroy(this.gameObject);
        }
    }
}
