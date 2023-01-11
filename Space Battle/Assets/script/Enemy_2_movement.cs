using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy_2_movement : MonoBehaviour
{
    public Animator anim;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;

    public float speed = 5.0f; 
    public float bulletRespawnTime = 7.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed/2, -speed);
        StartCoroutine(bulletShoot());
        

    }
    void Update()
    {
        if (transform.position.y < -6 )
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.x > 2 || transform.position.x < -2)
        {
            if (transform.position.x > 2)
            {
                rb.velocity = new Vector2(-speed/2, -speed);
            }
            else if (transform.position.x < -2)
            {
                rb.velocity = new Vector2(speed/2, -speed);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "bulletPlayer" || player.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    private void spawnBullet()
    {
        GameObject a = Instantiate(bulletPrefab) as GameObject;
        a.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
    IEnumerator bulletShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(bulletRespawnTime);
            spawnBullet();
        }
    }

   
}

