using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockchild : MonoBehaviour
{

    public float rotateSpeed = 400;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
    }

}
