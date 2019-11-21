using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Joystick joystick;
    private CapsuleCollider bounder;
    private List<GameObject> listPrevObstacleObject = new List<GameObject>();
    public static float Speed = 10;
    public GameObject player;
    public Camera cam;
    public GameObject GameOverPanel;
    public GameObject PotionText;

    private bool forwardFlag, backFlag, rightFlag, leftFlag;
    private float range = 0.7071f;
    private RaycastHit hitInfo;

    Image fill;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        fill = GameObject.Find("fill").GetComponent<Image>();
        bounder = GetComponent<CapsuleCollider>();
    }

    void Update()
    {

        if (StartPanel.isStart == true)
        {
            Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical) * Speed * Time.deltaTime;
            var rigidbody = GetComponent<Rigidbody>();
            checkNearby();

            transform.rotation = Quaternion.LookRotation(moveVector);


            if (joystick.Vertical == 0 && joystick.Horizontal == 0)
            {
                rigidbody.velocity = new Vector3(0, 0, 0);
            }
            if (forwardFlag && moveVector.z > 0)
            {
                moveVector = new Vector3(moveVector.x, moveVector.y, 0);
            }
            if (backFlag && moveVector.z < 0)
            {
                moveVector = new Vector3(moveVector.x, moveVector.y, 0);
            }
            if (rightFlag && moveVector.x > 0)
            {
                moveVector = new Vector3(0, moveVector.y, moveVector.z);
            }
            if (leftFlag && moveVector.x < 0)
            {
                moveVector = new Vector3(0, moveVector.y, moveVector.z);
            }
            transform.position += moveVector;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Speed = 40;
                Time.timeScale = 0.25f;
                Joybutton.isbtndown = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                Joybutton.isbtndown = false;
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            }


        }





        Vector3 pointCenter = transform.TransformPoint(bounder.center);
        Vector3 pointLeft = transform.TransformPoint(bounder.center) - new Vector3(bounder.radius, 0, 0);
        Vector3 pointRight = transform.TransformPoint(bounder.center) + new Vector3(bounder.radius, 0, 0);
        Vector3 pointUp = transform.TransformPoint(bounder.center) + new Vector3(0, bounder.height / 2.0f, 0);
        Vector3 pointDown = transform.TransformPoint(bounder.center) - new Vector3(0, bounder.height / 2.0f, 0);

        List<Ray> listRay = new List<Ray>();
        Vector3 targetPosition = cam.transform.position;   // camera world position

        listRay.Add(new Ray(pointCenter, targetPosition - pointCenter));
        listRay.Add(new Ray(pointLeft, targetPosition - pointLeft));
        listRay.Add(new Ray(pointRight, targetPosition - pointRight));
        listRay.Add(new Ray(pointUp, targetPosition - pointUp));
        listRay.Add(new Ray(pointDown, targetPosition - pointDown));

        List<RaycastHit[]> listHitInfo = new List<RaycastHit[]>();

        foreach (Ray ray in listRay)
        {
            RaycastHit[] hitInfo = Physics.RaycastAll(ray, 1000.0f);
            listHitInfo.Add(hitInfo);

            Debug.DrawRay(ray.origin, ray.direction * 500, Color.red);
        }

        RaycastHit[] listHit = listHitInfo[0];

        List<GameObject> listNewObstacleObject = new List<GameObject>();

        foreach (RaycastHit hitInfo in listHit)
        {
            if (gameObject.name == hitInfo.collider.name)
            {
                continue;
            }
            if (hitInfo.collider.name.Contains("Bip"))
            {
                continue;
            }

            if (FindColliderByName(listHitInfo[1], hitInfo.collider.name)
                && FindColliderByName(listHitInfo[2], hitInfo.collider.name)
                && FindColliderByName(listHitInfo[3], hitInfo.collider.name)
                && FindColliderByName(listHitInfo[4], hitInfo.collider.name)
                )
            {
                listNewObstacleObject.Add(hitInfo.transform.gameObject);
            }
        }
        foreach (GameObject obstacleObject in listNewObstacleObject)
        {
            // add
            if (!listPrevObstacleObject.Find(delegate (GameObject inObject) { return (inObject.name == obstacleObject.name); }))
            {
                if (obstacleObject.transform.tag == "wall")
                {
                    // changed to transparent
                    string nameShader = "Standard";

                    MeshRenderer renderer = obstacleObject.GetComponent<MeshRenderer>();

                    renderer.material.shader = Shader.Find(nameShader);
                    if (renderer.material.HasProperty("_Color"))
                    {
                        Color prevColor = renderer.material.GetColor("_Color");
                        renderer.material.SetColor("_Color", new Color(prevColor.r, prevColor.g, prevColor.b, 0.5f));
                    }
                }
                    

            }

        }
        // prev
        foreach (GameObject obstacleObject in listPrevObstacleObject)
        {
            // remove
            if (!listNewObstacleObject.Find(delegate (GameObject inObject) { return (inObject.name == obstacleObject.name); }))
            {
                // changed to opaque
                if(obstacleObject.transform.tag == "wall")
                {
                    string nameShader = "Standard";
                    MeshRenderer renderer = obstacleObject.GetComponent<MeshRenderer>();
                    renderer.material.shader = Shader.Find(nameShader);
                    Color prevColor = renderer.material.GetColor("_Color");
                    renderer.material.SetColor("_Color", new Color(prevColor.r, prevColor.g, prevColor.b, 1));
                }
                

            }
        }
        // swap
        listPrevObstacleObject = listNewObstacleObject;


    }

    private bool FindColliderByName(RaycastHit[] inListRayCastInfo, string inName)
    {
        foreach (RaycastHit hitInfo in inListRayCastInfo)
        {

            if (hitInfo.collider.name == inName)
            { return true; }
        }

        return false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "obs" && StartPanel.isStart == true) 
        {
            SoundManager.instance.SoundDie();
            PlayerDie.changeState(1);
            StartPanel.isStart = false;
            Time.timeScale = 1;
            Joybutton.isbtndown = false;
        }

        if (other.transform.tag == "item")
        {
            SoundManager.instance.SoundPotion();
            fill.fillAmount += 0.4f;
            other.gameObject.SetActive(false);
            Instantiate(PotionText, transform.position + new Vector3(7, 3, 2), Quaternion.identity);
        }
    }
    private void checkNearby()
    {
        if (Physics.Raycast(transform.position, Vector3.forward, out hitInfo, range))
        {
            if (hitInfo.transform.tag == "wall" || hitInfo.transform.tag == "invisibleWall") forwardFlag = true;
            else forwardFlag = false;
        }
        else forwardFlag = false;
        if (Physics.Raycast(transform.position, Vector3.back, out hitInfo, range))
        {
            if (hitInfo.transform.tag == "wall" || hitInfo.transform.tag == "invisibleWall") backFlag = true;
            else backFlag = false;
        }
        else backFlag = false;
        if (Physics.Raycast(transform.position, Vector3.right, out hitInfo, range))
        {
            if (hitInfo.transform.tag == "wall" || hitInfo.transform.tag == "invisibleWall") rightFlag = true;
            else rightFlag = false;
        }
        else rightFlag = false;
        if (Physics.Raycast(transform.position, Vector3.left, out hitInfo, range))
        {
            if (hitInfo.transform.tag == "wall" || hitInfo.transform.tag == "invisibleWall") leftFlag = true;
            else leftFlag = false;
        }
        else leftFlag = false;
    }

    public void gameover()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);

        PlayerDie.changeState(0);

        if (SavePoint.flag == true)
        {
            Score.score = 0;
        }

    }

}
