using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{

    public static int StageNum;

    private GameObject startposition;

    void Awake()
    {
        startposition = GameObject.Find("StartPosition");
    }

    void Start()
    {
        
    }

    void Update()
    {
        

        switch (StageNum)
        {
            case 1:

                startposition.transform.position = new Vector3(14.57f, 0.5f, -101.61f);
                break;

            case 2:

                startposition.transform.position = new Vector3(-150.48f, 0.5f, -82.73f);
                break;

            case 3:

                startposition.transform.position = new Vector3(-6.99f, 0.5f, -22.02f);
                break;

            case 4:

                startposition.transform.position = new Vector3(-388.62f, 0.5f, -83.04f);
                break;
        }


    }
}
