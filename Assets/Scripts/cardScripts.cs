using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;
// using UnityEngine.Vector3;

public class cardScripts : MonoBehaviour
{


    // 1 # DISPLAYING ALL AT ONCE AND DESTROYING AT ONCE 
    // 2 # SPAWN ONE BY ONE AND DESTROY ONE BY ONE


    public List<GameObject> prefabCards; // list for card prefabs
    List<GameObject>spawnedCards = new List<GameObject>();  // list for cards that are on screen 
    public int checkScore; // checking for score
    public int passScore; // checking for passscore
    int i; // for looping through prefabcards list
                int n = 1;
    int spacePressed;
    GameObject cards; // to store instantiated cards as game objects
    void DisplayCards()
    {
        // foreach (GameObject prefabCards) // cannot understand this at the momment
        // {
        //     for(int u = 0; u > 9; u++)
        //     {
        //         Debug.Log("for each | Prefabs");    
        //     }
            
        // }
        // for (i = 0; i < prefabCards.Count; i++) // looping through 
        // {
            // if(prefabCards[currentIndex] != null) // checking if prefab is there in the list
            // {
                // if(Input.GetKeyDown(KeyCode.Space)) // to Spawn one by one
                // {
                    // Vector3 pos = transform.position; // testing did'nt work
                    // transform.position = new Vector3(-130, -50 , 0); // testing did'nt work
                    Vector3 pos = new Vector3(-130, -50 , 0); // assigning starting position to instantiat frist card               
                    Vector3 offset = new Vector3(spacePressed * 40, spacePressed * 10, 2); // giving offsets in between cards
                    cards = Instantiate(prefabCards[spacePressed], pos + offset, Quaternion.identity);  // storing instantiated card as game objects
                    spawnedCards.Add(cards); // adding that instantiated card in spawnedcards list                    
                // }
                    spacePressed++;
            // }
            // Instantiate(prefabCards[i]);
        // }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // checking for inputs
        {
            Debug.Log(spacePressed);
            if(spacePressed < prefabCards.Count)
            {
                DisplayCards();    
            }
            else if(spacePressed >= prefabCards.Count)
            {
                Debug.Log("greater");
                spacePressed = prefabCards.Count;
                Destroy(spawnedCards[spacePressed - n]);
                n = (n * 2) - 1;

                Debug.Log(n);
            }

            // Debug.Log(currentIndex);
            // // Debug.Log("Start playing now");
            // if(checkScore > passScore) // checking again
            // {
            //     DisplayCards(); // does what it says
            //     Debug.Log(currentIndex);
                
            // }
            // else
            // {
            //     for (int j = 0; j < spawnedCards.Count; j++) // another loop to destroy cards on screen
            //     {
            //         // DestroyImmediate(prefabCards[j], true);    
            //         Destroy(spawnedCards[j]); // destroying all cards in spawnedCards list, in short on screen.
            //     }
            // }    
        }
    }
    }