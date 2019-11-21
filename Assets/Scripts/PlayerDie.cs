using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{

    public static Animator Player_Animator;

    const int STATE_IDLE = 0;
    const int STATE_DIE = 1;

    void Start()
    {
        Player_Animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public static void changeState(int state)
    {

        switch (state)
        {
            case STATE_DIE:
                Player_Animator.SetInteger("state", STATE_DIE);
                break;

            case STATE_IDLE:
                Player_Animator.SetInteger("state", STATE_IDLE);
                break;

        }
    }
}
