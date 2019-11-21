using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSimple : IMoveable
{
    private MoveableObs obs;
	public MoveSimple(MoveableObs moveableObs)
	{
        this.obs = moveableObs;
	}
    public void Move()
    { 
        obs.transform.position += new Vector3(obs.speed * Time.deltaTime, 0f, 0f);
    }
}
