using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 5.0f; 
    public Joystick joystick; 

    private Rigidbody2D rigidbody;
    private int minX = -3;
    private int maxX = 3;
    private int minY = -5;
    private int maxY = 5;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        
        Vector2 movement = new Vector2(horizontal, vertical);

        rigidbody.velocity = movement * speed;
        
        if (transform.position.x < minX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }

        if (transform.position.y < minY)
        {
            transform.position = new Vector2(transform.position.x, minY);
        }
        else if (transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, maxY);
        }
    }
    
}
