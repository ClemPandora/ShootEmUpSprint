using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float actualHealth;
    public Text healthBar;
    
    
    void Start()
    {
        healthBar.text = actualHealth.ToString();
    }

    private void Update()
    {
        if (  actualHealth > maxHealth)
        {
            healthBar.text = maxHealth.ToString() + "+";
        }

        if (actualHealth < maxHealth)
        {
            healthBar.text = actualHealth.ToString();
        }
    }

    public void TakeDamage(float damage)
    {
        actualHealth -= damage;

        healthBar.text = actualHealth.ToString();

      
        
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
