using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour {
    private GameObject playerObj;
    public GameObject activeSavePoint;
    public GameObject savePosition;
    private Vector3 savePos;
    public static bool flag;
    // Use this for initialization
	void Start () {
        flag = true;
        playerObj = GameObject.Find("Player");
        savePos = new Vector3(transform.position.x, 0.5f, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if(savePosition.transform.position == savePos )
        {
            SoundManager.instance.SoundSavePoint();
            activeSavePoint.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

        if (Vector3.Distance(playerObj.transform.position, transform.position) < 1.2f )
        {
            savePosition.transform.position = savePos;
            flag = false;
        }
	}
}
