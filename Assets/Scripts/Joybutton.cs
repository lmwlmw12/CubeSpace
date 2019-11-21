using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Joybutton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public static bool isbtndown;


    void Start()
    {
        isbtndown = false;
    }

    void Update()
    {
        if (isbtndown == true && StartPanel.isStart == true)
        {
            Player.Speed = 40;
            Time.timeScale = 0.25f;
        }
        if (isbtndown == false && StartPanel.isStart == true)
        {
            Time.timeScale = 1;
            Player.Speed = 10;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isbtndown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isbtndown = false;
    }
}
