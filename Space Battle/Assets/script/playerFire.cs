using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFire : MonoBehaviour
{
    public GameObject firePrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public bool canFire = true;

    public void fireButton()
    {
        if (canFire)
        {
            Fire();
            canFire = false;
            Invoke("ResetFire", fireRate);
        }
        
    }

    void Fire()
    {
        Instantiate(firePrefab, firePoint.position, firePoint.rotation);
    }

    void ResetFire()
    {
        canFire = true;
    }
}
