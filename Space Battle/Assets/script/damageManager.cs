using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageManager : MonoBehaviour
{
    Collider2D m_Collider;
    
    [SerializeField] private int enemyDamage;
    [SerializeField] private healthManager healthController;
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Bullet" || enemy.tag == "Enemy")
        {
            Damage();
        }
    }
    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - enemyDamage;
        healthController.UpdateHealth();
        
     
    }
}
