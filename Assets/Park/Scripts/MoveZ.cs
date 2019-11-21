using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ: IMoveable
{
    private float longitude;
    private MoveableObs obs;
    private bool flag;
	public MoveZ(MoveableObs moveableObs, float longitude)
	{
        this.obs = moveableObs;
        this.flag = true;
        this.longitude = longitude;
    }
    public void Move()
    {
        if (flag == true)
        {
            obs.transform.position += new Vector3(0, 0, obs.speed * Time.deltaTime);

            if (obs.transform.position.z > obs.firstPos.z)
            {
                flag = false;
            }
        }
        else if (flag == false)
        {
            obs.transform.position -= new Vector3(0, 0, obs.speed * Time.deltaTime);
            if (obs.transform.position.z < obs.firstPos.z - longitude)
            {
                flag = true;
            }
        }
    }
}
