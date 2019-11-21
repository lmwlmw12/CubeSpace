using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class threetofour : MonoBehaviour {

    public GameObject stage4Panel;

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

            if (Score.score < float.Parse(PlayerPrefs.GetString("bestscore3")))
            {
                PlayerPrefs.SetString("bestscore3", (Score.score).ToString("N2"));
                PlayerPrefs.Save();
            }

            PlayerPosition.StageNum = 4;
            stage4Panel.SetActive(true);
            Time.timeScale = 0;
            player.transform.position = new Vector3(-388.62f, 0.5f, -83.04f);
            SavePosition.transform.position = player.transform.position;
            fill.fillAmount = 1;

        }
    }
}
