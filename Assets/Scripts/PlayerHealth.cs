using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float actualHealth;
    public Text healthBar;
    
    
    void Start()
    {
        
        actualHealth = 10;
        healthBar.text = "PV : " + actualHealth.ToString();
    }

    private void Update()
    {
        if (  actualHealth > maxHealth)
        {
            healthBar.text = maxHealth.ToString() + "+";
        }

        if (actualHealth < maxHealth)
        {
            healthBar.text = "PV : " + actualHealth.ToString();
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
        SceneManager.LoadScene("GameOverScene");
    }

    public void HealthUp()
    {
        actualHealth++;
    }
}
