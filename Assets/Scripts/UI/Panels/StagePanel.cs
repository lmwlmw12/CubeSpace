using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagePanel : MonoBehaviour
{

    private GameObject player;
    private GameObject startposition;
    private GameObject savePosition;

    public GameObject startPanel;

    public static bool stage1;
    public static bool stage2;
    SoundManager soundManager;

    void Start()
    {
        player = GameObject.Find("Player");
        startposition = GameObject.Find("StartPosition");
        savePosition = GameObject.Find("SavePosition");
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        
    }

    public void Stage1()
    {
        PlayerPosition.StageNum = 1;

        SoundManager.instance.SoundClick();
        BackGroundMusic();
        player.transform.position = new Vector3(14.57f, 0.5f, -101.61f);
        savePosition.transform.position = new Vector3(14.57f, 0.5f, -101.61f);
        StartPanel.isStart = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Stage2()
    {
        PlayerPosition.StageNum = 2;
        
        SoundManager.instance.SoundClick();
        BackGroundMusic();
        savePosition.transform.position = new Vector3(-150.48f, 0.5f, -82.73f);
        player.transform.position = new Vector3(-150.48f, 0.5f, -82.73f);
        StartPanel.isStart = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Stage3()
    {
        PlayerPosition.StageNum = 3;

        SoundManager.instance.SoundClick();
        BackGroundMusic();
        savePosition.transform.position = new Vector3(-6.99f, 0.5f, -22.02f);
        player.transform.position = new Vector3(-6.99f, 0.5f, -22.02f);
        StartPanel.isStart = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Stage4()
    {
        PlayerPosition.StageNum = 4;

        SoundManager.instance.SoundClick();
        BackGroundMusic();
        savePosition.transform.position = new Vector3(-388.62f, 0.5f, -83.04f);
        player.transform.position = new Vector3(-388.62f, 0.5f, -83.04f);
        StartPanel.isStart = true;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void BackButton()
    {
        gameObject.SetActive(false);
        startPanel.SetActive(true);
    }

    public void BackGroundMusic()
    {
        soundManager.myAudio.Stop();
        soundManager.myAudio.clip = soundManager.Play_Sound;
        soundManager.myAudio.Play();
    }
}
