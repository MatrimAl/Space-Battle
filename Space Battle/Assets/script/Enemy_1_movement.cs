using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1_movement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public float speed = 5.0f; 
    public float bulletRespawnTime = 7.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        StartCoroutine(bulletShoot());
        StartCoroutine(animTimer());
    }
    void Update()
    {
        if (transform.position.y < -6 )
        {
            
            Destroy(this.gameObject);
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
    IEnumerator animTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }
}
