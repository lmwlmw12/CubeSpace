using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove2 : MoveableObs {
    [SerializeField]
    public float obsSpeed = 20f;
    [SerializeField]
    public float longitude = 20f;
    // Use this for initialization
	void Start () {
        base.Init(obsSpeed);
        base.SetStrategies(new MoveZ(this, longitude), new NotRotable());
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
}
