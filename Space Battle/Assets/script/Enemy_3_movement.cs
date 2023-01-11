using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Enemy_3_movement : MonoBehaviour
{
    public Animator anim;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public float speed = 5.0f; 
    public float bulletRespawnTime = 7.0f;
    private int direction = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, -speed);
        StartCoroutine(bulletShoot());
        StartCoroutine(animTimer());

    }
    void Update()
    {
        Move();
    }
    private void spawnBullet()
    {
        GameObject a = Instantiate(bulletPrefab) as GameObject;
        a.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "bulletPlayer" || player.tag == "Player")
        { 
            anim.SetTrigger("explode");
            rb.velocity = new Vector2(speed/2, -speed/2);
            animTimer();
            Destroy(this.gameObject);
        }
    }

    private void Move()
    {
        // Eğer karakterin y koordinatı 4'e eşitse, hareket yönünü değiştir
        if (transform.position.y < 4)
        {
            rb.velocity = new Vector2(speed/4, 0);
        }

        // Eğer karakterin x koordinatı -2'den küçük veya 2'den büyükse, hareket yönünü değiştir
        if (transform.position.x < -2 || transform.position.x > 2)
        {
            speed = speed * -1; 
            rb.velocity = new Vector2(speed/4, 0);
        }

    }
    IEnumerator bulletShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(bulletRespawnTime);
            spawnBullet();
        }
    }
    IEnumerator animTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }
}
