using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{

    private Image fill;

    void Start()
    {
        fill = GetComponent<Image>();
    }

    void Update()
    {
        UseSkill();
        RecoverySkill();
        if(fill.fillAmount == 0)
        {
            Joybutton.isbtndown = false;
        }
    }

    public void UseSkill()
    {
        if(Joybutton.isbtndown == true && StartPanel.isStart == true)
        {
            fill.fillAmount -= 0.003f;
                //Debug.Log(fill.fillAmount);
        }
    }

    public void RecoverySkill()
    {
        if(fill.fillAmount < 1 && Joybutton.isbtndown == false && StartPanel.isStart == true)
        {
            fill.fillAmount += 0.001f;  
        }
    }
}
