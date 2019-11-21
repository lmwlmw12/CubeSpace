using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageText : MonoBehaviour
{

    public Text stageText;

    void Start()
    {

    }

    void Update()
    {
        stageText.text = (PlayerPosition.StageNum).ToString();
    }
}
