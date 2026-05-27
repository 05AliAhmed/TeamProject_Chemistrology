// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;
// using TMPro;

// public class lvl3 : MonoBehaviour
// {
//     [SerializeField] int amendScore = 10;
//     int score;

//     public health scores3;
//     int presscount;
//     // Scene currentScn;
//     public string scnname;
//     [SerializeField]int loseScore;
//     [SerializeField] int combopoints;
//     [SerializeField] TMP_Text scoreTxt;
//     [SerializeField] TMP_Text highScoreTxt;
//     [SerializeField] float scoreNeedToPass;
//     // [SerializeField] HSManager highScore;
//     [SerializeField] Image progressbar;
//     // [SerializeField] GameObject HSManager;
//     // public void BackOption()
//     // {
//     //     SceneManager.LoadScene(0);
//     // }

//     public void ScoreSystem()
//     {
//         score += amendScore;
//         presscount++;
//         // Debug.Log(presscount);
//         // highScore.HighScore2();
//         if(presscount > 2)
//         {
//             score += combopoints;
//             // Debug.Log("Combo");
//         }        
//         if(score > PlayerPrefs.GetInt("Highscore3",0))
//         {
//             PlayerPrefs.SetInt("Highscore3", score);
//             highScoreTxt.text = score.ToString(); 
//         //     highScore.HighScore2();
//         }
//         scoreTxt.text = score.ToString();
//         // Debug.Log(score);
//     }

//     public void LoseScore()
//     {
//         score -= loseScore;
//         presscount = 0;
//         if(score < 0)
//         {
//             score = 0;
//         }
//         scoreTxt.text = score.ToString();
//     }

//     public void ChangeScr()
//     {
//         SceneManager.LoadScene(1);   
//     }
//     // void Awake()
//     // {
//     //     DontDestroyOnLoad(HSManager);
//     // }
//     void Start()
//     {
//         // currentScn  = SceneManager.GetActiveScene();
//         // Debug.Log(currentScn);
//         highScoreTxt.text = PlayerPrefs.GetInt("Highscore3", 0).ToString();
//         // highscoremanager.lvl2highscore()
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         scores3.score = score;
//         progressbar.fillAmount = (scoreNeedToPass - score)/ scoreNeedToPass;
//     }

// }
