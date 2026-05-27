// using UnityEngine;

// public class Health : MonoBehaviour
// {
//     [SerializeField] private int maxHp = 100;

//     int currentHp;

//     public int currentHP()
//     {
//         Mathf.Clamp(currentHp, 0, maxHp);
//         return currentHp;
//     }
//     public void TakeDamage(int value)
//     {
//         currentHp -= value;

//         if(currentHp < 0)
//         {
//             Debug.Log("Enemy is dead");
//         }
//     }
//     public interface IDamageable
//     {
//         void TakeDamage(int value);
//     }
//     void Start()
//     {
//         currentHp = maxHp;
//         GetComponent<Glock>().Fire();
//     }


//     void Update()
//     {
        
//     }
// }
