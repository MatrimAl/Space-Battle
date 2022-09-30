using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    public float runSpeed = 40f;

    float horizontal;
    float vertical;

    float y;
    float x;

    
    public Joystick joystick;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (joystick.Horizontal >= .2f)
        {
            body.velocity = new Vector2(horizontal * runSpeed, y);
        }
        else if (joystick.Horizontal <= -.2f)
        {
            body.velocity = new Vector2(horizontal * -runSpeed, y);
        }
        else if (joystick.Vertical >= .2f)
        {
            body.velocity = new Vector2(x, vertical * runSpeed);
        }
        else if (joystick.Vertical <= -.2f)
        {
            body.velocity = new Vector2(x, vertical * -runSpeed);
        }
    }
}
