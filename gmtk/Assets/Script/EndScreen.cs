using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public int endscore = 0;
    public Text finalscore;
   // public Text finalhighscore;
    // Start is called before the first frame update
    void Start()
    {
        //endscore = Highscore.instance.score;
        //finalscore.text = "Total Score: " + endscore.ToString();
       // finalhighscore.text = "Highscore: "+PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame() {
        SceneManager.LoadScene("GameScene");

    }
}
