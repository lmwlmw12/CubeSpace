using UnityEngine;

public class Rotable : IRotable
{
    [SerializeField]
    private MoveableObs obs;
    [SerializeField]
    private float speedRot;
    public Rotable(MoveableObs moveableObs, float speedRot)
    {
        this.obs = moveableObs;
        this.speedRot = speedRot * obs.speed;
    }
	public void Rotate()
    {
        Vector3 rotationY = new Vector3(0, speedRot * Time.deltaTime, 0);
        obs.transform.Rotate(rotationY);
    }
}
