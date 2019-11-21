using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject Rocket;

    private Vector3 RocketStartPos;

    public float distance = 5;
    public float speed = 0.2f;

    void Start()
    {
        RocketStartPos = Rocket.transform.localPosition;
    }

    void Update()
    {

        Rocket.transform.Translate( Vector3.up * speed* Time.deltaTime);

        if (Rocket.transform.localPosition.z >= distance)
        {
            Rocket.transform.localPosition = new Vector3(RocketStartPos.x, RocketStartPos.y, RocketStartPos.z);
        }
    }
}
