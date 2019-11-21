using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagClearPanel : MonoBehaviour
{

    private float loadingtime;

    void Start()
    {
        Score.score = 0;
        SavePoint.flag = true;
    }

    void Update()
    {
        if (loadingtime != 40)
        {
            loadingtime += 1;
        }
        else if (loadingtime == 40)
        {
            this.gameObject.SetActive(false);
            loadingtime = 0;

            SceneManager.LoadScene("Yu");
            Time.timeScale = 1;
        }
    }
}
