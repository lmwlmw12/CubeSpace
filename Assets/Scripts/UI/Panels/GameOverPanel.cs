using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{

    private GameObject player;
    private GameObject savePosition;

    public GameObject sheep;

    Image fill;

    void Start()
    {
        player = GameObject.Find("Player");
        savePosition = GameObject.Find("SavePosition");
        fill = GameObject.Find("fill").GetComponent<Image>();
    }

    void Update()
    {

    }

    public void Mainbtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Yu");
        
    }

    public void Restart()
    {
        SoundManager.instance.SoundClick();
        Time.timeScale = 1;
        StartPanel.isStart = true;
        gameObject.SetActive(false);
        player.transform.position = savePosition.transform.position;
        fill.fillAmount = 1;
        sheep.SetActive(true);
        SheepMove.flag = false;
        sheep.transform.localPosition = new Vector3(-5.143581f, 0.68f, -11.4549f);


    }


    public void Quit()
    {
        SoundManager.instance.SoundClick();
        Application.Quit();
    }

}
