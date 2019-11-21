using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardPanel : MonoBehaviour
{

    public Text Score1;
    public Text Score2;
    public Text Score3;
    public Text Score4;

    public GameObject startPanel;

    void Start()
    {
    }

    void Update()
    {
        if(PlayerPrefs.GetString("bestscore1") == "999")
        {
            Score1.text = "0";
        }
        else
        {
            Score1.text = PlayerPrefs.GetString("bestscore1");
        }

        if (PlayerPrefs.GetString("bestscore2") == "999")
        {
            Score2.text = "0";
        }
        else
        {
            Score2.text = PlayerPrefs.GetString("bestscore2");
        }

        if (PlayerPrefs.GetString("bestscore3") == "999")
        {
            Score3.text = "0";
        }
        else
        {
            Score3.text = PlayerPrefs.GetString("bestscore3");
        }

        if (PlayerPrefs.GetString("bestscore4") == "999")
        {
            Score4.text = "0";
        }
        else
        {
            Score4.text = PlayerPrefs.GetString("bestscore4");
        }




    }

    public void BackButton()
    {
        gameObject.SetActive(false);
        startPanel.SetActive(true);
    }
}
