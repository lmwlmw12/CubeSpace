using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRack : MonoBehaviour {
    private GameObject playerObj;
    private float upSpeed = 1.5f;
    private float maxUp = 0.45f;
    private bool flag = true;
	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(playerObj.transform.position, transform.position) < 1.6f && flag){
            Rigidbody playerBody = playerObj.GetComponent<Rigidbody>();
            playerBody.velocity = new Vector3(0, 2f, 0);
            flag = false;
        }else if (!flag && transform.position.y <= maxUp){
            transform.Translate(new Vector3(0, upSpeed * Time.deltaTime, 0));
        }
    }
}
