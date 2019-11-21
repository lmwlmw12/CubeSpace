using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twotothree : MonoBehaviour
{

    public GameObject stage3Panel;

    private GameObject player;

    private GameObject SavePosition;
    Image fill;

    void Start()
    {
        player = GameObject.Find("Player");
        fill = GameObject.Find("fill").GetComponent<Image>();
        SavePosition = GameObject.Find("SavePosition");
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {

            if (Score.score < float.Parse(PlayerPrefs.GetString("bestscore2")))
            {
                PlayerPrefs.SetString("bestscore2", (Score.score).ToString("N2"));
                PlayerPrefs.Save();
            }

            PlayerPosition.StageNum = 3;
            stage3Panel.SetActive(true);
            Time.timeScale = 0;
            player.transform.position = new Vector3(-6.99f, 0.5f, -22.02f);
            SavePosition.transform.position = player.transform.position;
            fill.fillAmount = 1;

        }
    }
}