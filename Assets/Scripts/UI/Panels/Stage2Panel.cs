using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Panel : MonoBehaviour
{

    public GameObject player;
    private float loadingtime;

    // Use this for initialization
    void Start()
    {
        Score.score = 0;
        SavePoint.flag = true;
    }

    // Update is called once per frame
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
        }

    }
}
