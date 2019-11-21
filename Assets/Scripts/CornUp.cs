using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornUp : MonoBehaviour
{

    public float maxDown = -0.85f;
    public float maxUp = 0.08f;
    public float updownSpeed = 1.5f;
    public float delay = 1f;


    private bool isUp;

    void Start()
    {
        
    }


    void Update()
    {
        if (isUp)
        {
            Invoke("cornDown", delay);
        }
        
        if (isUp == false)
        {
            Invoke("cornUp", delay);
        }
 
        
    }

    public void cornDown()
    {
        if(transform.position.y > maxDown)
        {
            transform.Translate(Vector3.down * updownSpeed * Time.deltaTime);
        }

        if(transform.position.y < maxDown)
        {
            isUp = false;
        }
    }

    public void cornUp()
    {
        if (transform.position.y < maxUp)
        {
            transform.Translate(Vector3.up * updownSpeed * Time.deltaTime);
        }

        if (transform.position.y > maxUp)
        {
            isUp = true;
        }
    }

}
