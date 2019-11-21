using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCubeMove : MonoBehaviour {

    private float collidetime;
    private bool a = true;
    private float speed = 30;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (a == true)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            if (transform.localPosition.x < -20)
            {
                collidetime += Time.deltaTime;
                
                if (collidetime > 3)
                {
                    a = false;
                    collidetime = 0;
                }
               
            }
        }
        else if (a == false)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            if (transform.localPosition.x >= -11.9)
            {
                    a = true;             
            }
        }



    }
}
