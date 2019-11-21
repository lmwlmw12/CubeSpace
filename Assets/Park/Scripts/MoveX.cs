using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : IMoveable
{
    private float longitude;
    private MoveableObs obs;
    private bool flag;
	public MoveX(MoveableObs moveableObs, float longitude)
	{
        this.obs = moveableObs;
        this.flag = true;
        this.longitude = longitude;
    }
    public void Move()
    {
        if (flag == true)
        {
            obs.transform.position += new Vector3(obs.speed * Time.deltaTime, 0, 0);

            if (obs.transform.position.x > obs.firstPos.x)
            {
                flag = false;
            }
        }
        else if (flag == false)
        {
            obs.transform.position -= new Vector3(obs.speed * Time.deltaTime, 0, 0);
            if (obs.transform.position.x < obs.firstPos.x - longitude)
            {
                flag = true;
            }
        }
    }
}
