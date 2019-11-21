using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	void Start ()
    {
        //offset = player.transform.position - transform.position;

    }
	
	void Update ()
    {
        if(StartPanel.isStart == true)
        transform.position = player.transform.position - new Vector3(0, -45.09f, 31.15f);
	}
}
