using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    public bool immuneToDamage;

    public delegate void OnHealthChange(int health, GameObject go);
    public static event OnHealthChange onHealthChange;

    private void Start()
    {
        HealthUpdate();
        
    }
    
    public void AddHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth += amount, 0, maxHealth);
        HealthUpdate();
    }

    public void TakeDamage(int damage) 
    {
        if (!immuneToDamage)
        {
            currentHealth = Mathf.Clamp(currentHealth -= damage, 0, maxHealth); // reduce hp
            
            if (IsDead()) // if health == 0
                gameObject.SendMessage("Death", SendMessageOptions.DontRequireReceiver);
        }
        HealthUpdate();
    }

    private void HealthUpdate()
    {
        float currentHealthPercentage = 1f / maxHealth * currentHealth;
        if (onHealthChange != null)
        {
            onHealthChange(currentHealth, gameObject);
        }
    }

    private bool IsDead() 
    {
        return currentHealth == 0;  
    }
}
