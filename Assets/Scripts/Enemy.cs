using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int movingSpeed;
    [SerializeField] string enemyName;
    [SerializeField] int enemyHealth;
    
    void Start()
    {

    }

    void Update()
    {
        EnemyMovement();
        
    }

    void LateUpdate()
    {
       
    }

    void EnemyMovement()
    {
        transform.position = new Vector3(transform.position.x - movingSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }
   
    

   

        
}

