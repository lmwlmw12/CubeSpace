using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour {

    public GameObject soundOn;
    public GameObject soundOff;


    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {

    }

    public void MainButton()
    {
        SceneManager.LoadScene("Yu");
        Time.timeScale = 1;

       

    }

    public void ResumeButton()
    {
        this.gameObject.SetActive(false);
        StartPanel.isStart = true;
        Time.timeScale = 1;
        SoundManager.instance.SoundClick();


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
