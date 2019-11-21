using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public static float score;
    public static float bestscore;



    void Start()
    {
        

    }

    void Update()
    {

        if (StartPanel.isStart == true)
        {


            score += Time.deltaTime;
            scoreText.text = score.ToString("N2");
            
        }

        if (PlayerPrefs.HasKey("bestscore1") == false)
        {
            PlayerPrefs.SetString("bestscore1", "999");
        }

        if (PlayerPrefs.HasKey("bestscore2") == false)
        {
            PlayerPrefs.SetString("bestscore2", "999");
        }

        if (PlayerPrefs.HasKey("bestscore3") == false)
        {
            PlayerPrefs.SetString("bestscore3", "999");
        }

        if (PlayerPrefs.HasKey("bestscore4") == false)
        {
            PlayerPrefs.SetString("bestscore4", "999");
        }

    }

    
}



