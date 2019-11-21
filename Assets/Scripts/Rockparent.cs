using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockparent : MonoBehaviour
{

    public GameObject startPosition;
    public float resetPosition = -15f;
    public float moveSpeed = 10;


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < resetPosition)
        {
            transform.position = startPosition.transform.position;
        }

    }

    
}
