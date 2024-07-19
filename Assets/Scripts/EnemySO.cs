using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu]
public class EnemySO : ScriptableObject
{
   public string enemyName;
   public int enemyHealth;
    public float enemyDamage;
    public Sprite enemySprite;
    public int spawningMaxCount;
    public int currentSpawningCount;
    public int initialSpawnCount = 0;
    
    
}
