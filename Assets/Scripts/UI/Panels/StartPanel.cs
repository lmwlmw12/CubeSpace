using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{

    public GameObject stagepanel;
    public GameObject ScoreBoardPanel;

    public static bool isStart;

    public GameObject soundOn;
    public GameObject soundOff;

    Image SourceImage;

    void Start()
    {
        isStart = false;
        //Time.timeScale = 0;

        
    }

    
    void Update()
    {
        
    }

    public void StartButton()
    {
        gameObject.SetActive(false);
        stagepanel.SetActive(true);

        SoundManager.instance.SoundClick();
    }

    public void ScoreBoard()
    {
        ScoreBoardPanel.SetActive(true);
    }

    public void SoundOn()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true);

        SoundManager.instance.SoundClick();
        SoundManager.instance.SoundOff();
    }

    public void SoundOff()
    {
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        
        SoundManager.instance.SoundClick();
        SoundManager.instance.SoundOn();
    }

    public void Quit()
    {
        Application.Quit();
        SoundManager.instance.SoundClick();
        
    }

}