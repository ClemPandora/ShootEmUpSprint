using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float actualHealth;

    public Slider healthBar;
    
    
    void Start()
    {
        actualHealth = maxHealth;

        healthBar.highValue = maxHealth;
        healthBar.value = actualHealth;
    }
    
    public void TakeDamage(float damage)
    {
        actualHealth -= damage;

        healthBar.value = actualHealth;
        
        if (actualHealth <= 0)
        {
            Death();
        }
    }
    
    public void Death()
    {
        Destroy(gameObject);
    }
}
