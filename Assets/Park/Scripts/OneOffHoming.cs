using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneOffHoming : IMoveable
{
    private MoveableObs obs;
    public OneOffHoming(MoveableObs moveableObs)
    {
        this.obs = moveableObs;
    }
    public void Move()
    {
        Vector3 Pos;
        Quaternion NewRotation;
        Vector3 heading = (obs.GetPlayerPos() - obs.transform.position).normalized;
        //방향 벡터 구하고 
        //외적, Axis 축 구하고 
        Vector3 Axis = Vector3.Cross(heading, obs.transform.forward);
        //angle - 휘는각도 높으로수록 정확도 나옴.. 
        //Axis - 축
        NewRotation = Quaternion.AngleAxis(obs.speed / 10, Axis) * obs.transform.rotation;
        //좀더 부드럽게 회전 - 안하면 좀 각져보임.. 해도 되고 안해도 됨... 
        obs.transform.rotation = Quaternion.Lerp(obs.transform.rotation, NewRotation, obs.speed * Time.deltaTime);
        //Vector3(0,0,1) 방향 초당 속도로 
        Pos = obs.transform.forward * Time.deltaTime * obs.speed;
        //내 위치 지정 
        obs.transform.Translate(Pos);
    }
}
