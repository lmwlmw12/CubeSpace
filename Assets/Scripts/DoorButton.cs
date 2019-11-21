using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{

    public float maxDown = -0.04f;
    public float maxUp = 0.06f;
    public float updownSpeed = 0.5f;

    Door door;

    private bool isColl ;

    void Start()
    {
        door = GameObject.Find("Door").GetComponent<Door>();
    }

    void Update()
    {
        if (isColl)
        {
            ButtonDown();
            door.OpenDoor();
        }
        if(!isColl)
        {
            ButtonUp();
            door.CloseDoor();
        }


    }

    void OnTriggerStay(Collider other)
    {
        isColl = true;
    }

    void OnTriggerExit(Collider other)
    {
        isColl = false;
    }

    public void ButtonDown()
    {
        if(transform.position.y >= maxDown)
        {
            transform.Translate(Vector3.down * updownSpeed * Time.deltaTime);
        }
    }

    public void ButtonUp()
    {
        if (transform.position.y <= maxUp)
        {
            transform.Translate(Vector3.up * updownSpeed * Time.deltaTime);
        }
    }

}
