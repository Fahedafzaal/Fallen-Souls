using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] HealthBar _healthBar;
    [SerializeField] StaminaBar _staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Testing dmg & heal
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(GameManager.gameManager._playerHealth.currentHealth);
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager._playerHealth.currentHealth);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log(GameManager.gameManager._playerHealth.currentHealth);
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.currentHealth);
        }
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.currentHealth);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.currentHealth);
    }
    private void PlayerUseStamina(float staminaAmount)
    {
        GameManager.gameManager._playerStamina.UseStamina(staminaAmount);
        _staminaBar.SetStamina(GameManager.gameManager._playerStamina.Stamina);
    }
    private void PlayerRegenStamina()
    {
        GameManager.gameManager._playerStamina.RegenStamina();
        _staminaBar.SetStamina(GameManager.gameManager._playerStamina.Stamina);
    }
    public void PlayerRegenStaminaOnKill()
    {
        GameManager.gameManager._playerStamina.RegenStaminaOnKill();
        _staminaBar.SetStamina(GameManager.gameManager._playerStamina.Stamina);
    }
}
