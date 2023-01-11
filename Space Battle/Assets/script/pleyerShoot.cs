using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pleyerShoot : MonoBehaviour
{
    public GameObject bulletPlayer;
    public bool canFire = true;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                print("Deneme");
            }
        }
    }
    private void spawnBullet()
    {
        GameObject a = Instantiate(bulletPlayer) as GameObject;
        a.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
    IEnumerator bulletShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            spawnBullet();
        }
    }
}
