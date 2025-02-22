using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health 
{
    // Fields
    int _currentHealth;
    int _maxHealth;

    // Constructor
    public Health(int health, int maxHealth)
    {
        _currentHealth = health;
        _maxHealth = maxHealth;
    }

    // Properties
    public int currentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
        }
    }

    public int maxHealth
    {
        get
        {
            return _maxHealth;
        }
        set
        {
            _maxHealth = value;
        }
    }

    // Method
    public void DmgUnit(int dmgAmount)
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }

    public void HealUnit(int healAmount)
    {
        if (_currentHealth < _maxHealth)
        {
            _currentHealth += healAmount;
        }
        if (_currentHealth > maxHealth)
        {
            _currentHealth = maxHealth;
        }
    }
    
}
