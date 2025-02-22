using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager {  get; private set; }

    public Health _playerHealth = new Health(100, 100);
    public UnitStamina _playerStamina = new UnitStamina(100f, 100f, 30f, false, 50f);

    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
}
