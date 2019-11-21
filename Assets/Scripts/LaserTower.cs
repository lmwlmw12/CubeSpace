using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTower : MonoBehaviour {

    public float rotateSpeed = 150;
    public float direction = 1;


	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * direction * Time.deltaTime, 0));
	}
}
