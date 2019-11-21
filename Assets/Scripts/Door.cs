using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public float closeSpeed = 50f;
    public float openSpeed = 50f;

    public void OpenDoor()
    {
        if(transform.localEulerAngles.y < 120)
        {
            transform.eulerAngles += new Vector3(0, openSpeed * Time.deltaTime, 0);
        }
    }

    public void CloseDoor()
    {
        if (transform.localEulerAngles.y > 4)
        {
            transform.eulerAngles -= new Vector3(0, closeSpeed * Time.deltaTime, 0);
        }
    }
}