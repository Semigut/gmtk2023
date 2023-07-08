using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public static Highscore instance;

    public Text highscore;
    public int score = 0;

   private void Awake() { 

        instance = this;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = "Highscore: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppPoint()
    {
        score += 1;
        highscore.text = "Highscore: " + score.ToString();

      
    }
}
    