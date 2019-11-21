using UnityEngine;
using System.Collections;

public class StoneMove : MonoBehaviour
{
    private float speed = 500;
    private float runningTime = 0;
    public float radius;
    public GameObject CenterStone;

    private Vector3 newPos = new Vector3();
    // Use this for initialization
    void Start()
    {

    }




    void Update()
    {
        transform.RotateAround(CenterStone.transform.position, Vector3.down, speed * Time.deltaTime);
        /* runningTime += Time.deltaTime * speed;
         float x = radius * Mathf.Cos(runningTime);
         float y = radius * Mathf.Sin(runningTime);
         newPos = new Vector3(x, 0.5f, y);
         this.transform.position = newPos;*/

    }



}
