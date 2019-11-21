using UnityEngine;
using UnityEditor;

public class SheepMove : MonoBehaviour
{
    public float speed = 5;
    Vector3 lookDirection;

    public GameObject player;

    public static bool flag;

    Vector3 SheepStartPos;

    void Start()
    {
        flag = false;
        SheepStartPos = transform.position;
    }

    void Update()
    {
        if(player.transform.position.z > 34)
        {
            flag = true;
        }

        if (flag)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if(transform.localPosition.x > 30)
        {
            flag = false;
            this.gameObject.SetActive(false);
            transform.position = SheepStartPos;
        }
    }
}