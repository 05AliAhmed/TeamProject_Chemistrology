// using Unity.Collections;
// using UnityEngine;

// public class Obstaclespawn : MonoBehaviour
// {
//     [SerializeField] GameObject ObstaclePrefab;
//     [SerializeField] GameObject testingrotation;
//     [SerializeField] Transform parent;
//     [SerializeField] int numberOfObjects = 20;
//     [SerializeField] float radius = 5f;
//     [SerializeField] float rotationSpeed = 2;
    

//     void Start()
//     {
//         for (int i = 0; i < numberOfObjects; i++)
//         {
//             float angle = i * Mathf.PI * 2 / numberOfObjects;
//             float x = Mathf.Cos(angle) * radius;
//             float y = Mathf.Sin(angle) * radius;  // Y instead of Z for 2D
//             Vector2 pos = (Vector2)transform.position + new Vector2(x, y);
//             float angleDegrees = -angle * Mathf.Rad2Deg;
//             Quaternion rot = Quaternion.Euler(0, 0, angleDegrees);  // Z-axis rotation for 2D
//             Instantiate(ObstaclePrefab, pos, rot, parent);
//         }
//     }
 
//     void Update()
//     {
//         // rotate testing
//         // rotationSpeed = rotationSpeed * Time.deltaTime;
//         testingrotation.transform.Rotate(0f,0f, rotationSpeed);
//     }
// }
