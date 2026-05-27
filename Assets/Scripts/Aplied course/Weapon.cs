// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Rendering;

// public class Weapon : MonoBehaviour
// {
//     public virtual void Fire()
//     {
//         Debug.Log("basse weapon 1");
//     }
//     // public abstract void Fire();

//     public enum WeaponType
//     {
//         Pistol,
//         Rocket,
//         Laser
//     }

//     List<enemy> enemies = new(); // type of storage


// // type of storage // declearing
//     Dictionary<WeaponType, int> name1 = new();
//     Dictionary<int, int> name2 = new();
//     Dictionary<string, enemy> name3 = new();



//     void Eat()
//     {
//         // storing and 
//         name1[WeaponType.Rocket] = 3;
//         name2[5] = 3;
//         name3["storage"] = new enemy();
//         // collecting
//         int tempAmmo1 = name1[WeaponType.Rocket];
//         int tempAmmo2 = name2[5];
//         enemy tempAmmo3 = name3["storage"];

//     // storig for list
// enemies.Add(new enemy());

//     // collecting of interacting for list
//         foreach (enemy e in enemies)
//         {
//             e.TakeDamage(1);
//         }
//     }
// }
