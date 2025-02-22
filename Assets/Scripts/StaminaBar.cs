using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    Slider _staminaSlider;

    private void Start()
    {
        _staminaSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(float maxStamina)
    {
        _staminaSlider.maxValue = maxStamina;
        _staminaSlider.value = maxStamina;
    }
    public void SetStamina(float stamina)
    {
        _staminaSlider.value = stamina;
    }
}
