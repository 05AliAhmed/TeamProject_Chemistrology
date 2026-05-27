// using System.Collections;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.SocialPlatforms.Impl;
// using UnityEngine.UI;

// public class health : MonoBehaviour
// {
//     //     // public static health instance;
//     // //     public int currentHealth;
//     // //     public int fullHP;

//     // //     public Sprite emptyHeart;
//     //     // public Sprite fullHeart;
//     //     // public Image[] hearts;
//     //     public int score;
//     //     // Lvl1_Buttons lvl1script;
//     //     // Score score;

//     //     public Image star1;
//     //     public Image star2;
//     //     public Image star3;
//     //     public int pnt1;
//     //     public int pnt2;
//     //     public int pnt3;

//     //     int currentScnIndex;

//     //     // Start is called before the first frame update
//     //     void Start()
//     //     {
//     //         // lvl1script = GetComponent<Lvl1_Buttons>();
//     //         // for (int i = 0; i < hearts.Length; i++)
//     //         // {
//     //         //     // hearts[i].enabled = false;
//     //         // }
//     //         currentScnIndex = SceneManager.GetActiveScene().buildIndex; // this is when score is publically assigned here/gamemanager script to be used in other scripts/scns
//     //         star1.enabled = false;
//     //         star2.enabled = false;
//     //         star3.enabled = false;        
//     //     }

//     //     void DisplayStars()
//     //     {
//     //         if(score >= pnt1 && score < pnt2)
//     //         {
//     //             // Debug.Log("star 1");
//     //             // hearts[i].enabled = true;
//     //             star1.enabled = true;
//     //         }
//     //         else if(score >= pnt2 && score < pnt3)
//     //         {
//     //             // Debug.Log("star 1 and 2");
//     //             star1.enabled = true;
//     //             star2.enabled = true;
//     //             // hearts[i].enabled = true;
//     //         }
//     //         else if(score >= pnt3)
//     //         {
//     //             // Debug.Log("star 1,2,3");
//     //             star1.enabled = true;
//     //             star2.enabled = true;
//     //             star3.enabled = true;
//     //             // hearts[i].enabled = true;
//     //         }
//     //         else
//     //         {
//     //             star1.enabled = false;
//     //             star2.enabled = false;
//     //             star3.enabled = false;
//     //             // hearts[i].enabled = false;
//     //         }

//     //     }
//     //     // void Awake()
//     //     // {
//     //     //     if(instance == null)
//     //     //     {
//     //     //         instance = this;
//     //     //         DontDestroyOnLoad(gameObject);
//     //     //     }
//     //     //     else
//     //     //     {
//     //     //         Destroy(gameObject);
//     //     //     }
//     //     // }

//     //     // Update is called once per frame
//     //     void Update()
//     //     {
//     //         if(score >= pnt1 && score < pnt2)
//     //         {
//     //             // Debug.Log("star 1");
//     //             // hearts[i].enabled = true;
//     //             star1.enabled = true;
//     //         }
//     //         else if(score >= pnt2 && score < pnt3)
//     //         {
//     //             // Debug.Log("star 1 and 2");
//     //             star1.enabled = true;
//     //             star2.enabled = true;
//     //             // hearts[i].enabled = true;
//     //         }
//     //         else if(score >= pnt3)
//     //         {
//     //             // Debug.Log("star 1,2,3");
//     //             star1.enabled = true;
//     //             star2.enabled = true;
//     //             star3.enabled = true;
//     //             // hearts[i].enabled = true;
//     //         }
//     //         else
//     //         {
//     //             star1.enabled = false;
//     //             star2.enabled = false;
//     //             star3.enabled = false;
//     //             // hearts[i].enabled = false;
//     //         }
//     //         // for (int i = 0; i < hearts.Length; i++)
//     //         // {
//     //             // if (i < currentHealth)
//     //             // {
//     //             //     hearts[i].sprite = fullHeart;
//     //             // }
//     //             // else
//     //             // {
//     //             //     hearts[i].sprite = emptyHeart;
//     //             // }
//     //             // if(score >= pnt1)
//     //             // {
//     //             //     // hearts[i].enabled = true;
//     //             //     star1.enabled = true;
//     //             // }
//     //             // else if(score >= pnt2)
//     //             // {
//     //             //     star1.enabled = true;
//     //             //     star2.enabled = true;
//     //             //     // hearts[i].enabled = true;
//     //             // }
//     //             // else if(score >= pnt3)
//     //             // {
//     //             //     star1.enabled = true;
//     //             //     star2.enabled = true;
//     //             //     star3.enabled = true;
//     //             //     // hearts[i].enabled = true;
//     //             // }
//     //             // else
//     //             // {
//     //             //     star1.enabled = false;
//     //             //     star2.enabled = false;
//     //             //     star3.enabled = false;
//     //             //     // hearts[i].enabled = false;
//     //             // }
//     //         // }
//     //     }

//     [SerializeField] GameObject sprite;
//     public Sprite qbject;
//     private Coroutine flashRoutine;

//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Space))
//         {
//             if(flashRoutine != null)
//             {
//                 StopCoroutine(flashRoutine);
//             }
//         }
//     }

//     // private IEnumerator FlashRed()
//     // {
//     //     // sprite.color = Color.red;
//     //     // yield return new WaitForSeconds(0.1f);
//     // //     // sprite.color = Color.white;
//     // }
// }
