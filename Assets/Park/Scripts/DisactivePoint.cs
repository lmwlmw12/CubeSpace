using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisactivePoint : MonoBehaviour {

    private GameObject playerObj;
    public GameObject disactivePoint;
    public GameObject savePosition;

	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(savePosition.transform.position != new Vector3(transform.position.x, 0.5f, transform.position.z))
        {
            disactivePoint.SetActive(true);
            gameObject.SetActive(false);
        }
	}
}
