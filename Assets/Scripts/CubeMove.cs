using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    private bool a = true;
    private float speed = 10;

    void Start()
    {

    }

    void Update()
    {

        if (a == true)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            if (transform.position.x > -24)
            {
                a = false;
            }
        }
        else if (a == false)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if (transform.position.x < -34)
            {
                a = true;
            }
        }
    }
}
