using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    private float speed = 60f;
    private float maxUp = 70f;
    private GameObject playerObj;
    public ArrivedPortal arrivedPortal;
    // Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(playerObj.transform.position, transform.position) < 0.8f && transform.localScale.y < maxUp)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + speed * Time.deltaTime, transform.localScale.z);
            playerObj.transform.position = transform.position;
        }
        if(transform.localScale.y >= maxUp)
        {
            playerObj.transform.position = new Vector3(arrivedPortal.transform.position.x, 0.5f, arrivedPortal.transform.position.z);
            transform.localScale = new Vector3(transform.localScale.x, 0.85f, transform.localScale.z);
            arrivedPortal.flag = true;
        }
	}
}
