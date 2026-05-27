// using UnityEngine;

// public class enemy : MonoBehaviour, IDamagable 
// {
//     int hp;
//     public void TakeDamage(int value)
//     {
//         hp -= value;

//         if(hp < 0)
//         {
//             Debug.Log("Enemy is dead");
//         }
//     }
//     Health enemyHealth;
//     void Start()
//     {
//         // playerhealth = GetComponent<Health>();
//         enemyHealth = FindObjectOfType<Health>();
//         hp = enemyHealth.currentHP();
//     }

//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Space))
//         {
//             enemyHealth.TakeDamage(50);
//             Debug.Log(enemyHealth.currentHP());    
//         }
        
//     }
// }
