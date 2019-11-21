using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivedPortal : MonoBehaviour {
    private float maxDown = 0.85f;
    private float speed = 60f;
    public bool flag;
	// Use this for initialization
	void Start () {
        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (flag)
        {
            flag = false;
            transform.localScale = new Vector3(transform.localScale.x, 60f, transform.localScale.z);
        }
        if (transform.localScale.y > maxDown)
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - speed * Time.deltaTime, transform.localScale.z);
	}
}
