using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStamina : MonoBehaviour
{
    // Fields
    float _currentStamina;
    float _maxStamina;
    float _staminaRegenSpeed;
    bool _pauseStaminaRegen = false;
    float _staminaOnKill;

    // Constructor
    public UnitStamina(float stamina, float maxStamina, float staminaRegenSpeed, bool pauseStaminaRegen, float staminaOnKill)
    {
        _currentStamina = stamina;
        _maxStamina = maxStamina;
        _staminaRegenSpeed = staminaRegenSpeed;
        _pauseStaminaRegen = pauseStaminaRegen;
        _staminaOnKill = staminaOnKill;
    }

    // Properties
    public float Stamina
    {
        get
        {
            return _currentStamina;
        }
        set
        {
            _currentStamina = value;
        }
    }

    // Set and Get
    public float maxHealth
    {
        get
        {
            return _maxStamina;
        }
        set
        {
            _maxStamina = value;
        }
    }

    public bool pauseStaminaRegen
    {
        get
        {
            return _pauseStaminaRegen;
        }
        set
        {
            _pauseStaminaRegen = value;
        }
    }

    // Methods
    public void UseStamina(float staminaAmount)
    {
        if (_currentStamina > 0)
        {
            _currentStamina -= staminaAmount * Time.deltaTime;
        }
    }

    public void RegenStamina()
    {
        if (_currentStamina < _maxStamina && !_pauseStaminaRegen)
        {
            _currentStamina += _staminaRegenSpeed * Time.deltaTime ;
        }
    }

    public void RegenStaminaOnKill()
    {
        _currentStamina += _staminaOnKill;
        if (_currentStamina > _maxStamina)
        {
            _currentStamina = _maxStamina;
        }
    }
}
