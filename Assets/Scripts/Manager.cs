using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public GameObject pausePanel;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }

    void Update()

    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape) && StartPanel.isStart == true)
            {
                StartPanel.isStart = false;
                Time.timeScale = 0;
                pausePanel.SetActive(true);

            }
        }


    }

}
