using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fourtofive : MonoBehaviour
{

    public GameObject stageClearPanel;

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

            if (Score.score < float.Parse(PlayerPrefs.GetString("bestscore4")))
            {
                PlayerPrefs.SetString("bestscore4", (Score.score).ToString("N2"));
                PlayerPrefs.Save();
            }

            //PlayerPosition.StageNum = 4;
            stageClearPanel.SetActive(true);
            Time.timeScale = 0;
            player.transform.position = new Vector3(0f, 0.5f, 0f);
            //SavePosition.transform.position = player.transform.position;
            fill.fillAmount = 1;

        }
    }
}
