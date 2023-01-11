using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy_1_Prefab;
    public GameObject enemy_2_Prefab;
    public GameObject coin_Prefab;
    public float enemy_1_timer = 8.0f;
    public float enemy_2_timer = 8.0f;
    public float coin_timer = 8.0f;
    void Start()
    {
        StartCoroutine(enemy_1_wave());
        StartCoroutine(enemy_2_wave());
        StartCoroutine(coin_wave());
    }
    IEnumerator enemy_1_wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemy_1_timer);
            enemy_1_spawn();
        }
        
    }
    IEnumerator enemy_2_wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemy_2_timer);
            enemy_2_spawn();
        }
        
    }
    
    IEnumerator coin_wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(coin_timer);
            coin_spawn();
        }
    }
    private void enemy_1_spawn()
    {
        GameObject a = Instantiate(enemy_1_Prefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-2, 2), 8);
         
    }
    private void enemy_2_spawn()
    {
        GameObject b = Instantiate(enemy_2_Prefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-2, 2), 8);
        
    }
    
    private void coin_spawn()
    {
        GameObject d = Instantiate(coin_Prefab) as GameObject;
        d.transform.position = new Vector2(Random.Range(-2, 2), 8);
         
    }
}
