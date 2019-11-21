using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeAndGoMove : MoveableObs {
    [SerializeField]
    public float obsSpeed = 20f;
    [SerializeField]
    public float longitude = 20f;
    // Use this for initialization
    void Start () {
        base.Init(10f);
        base.SetStrategies(new MoveX(this, longitude), new NotRotable());
    }
	
	// Update is called once per frame
	void Update () {
        Move();
        Rotate();
	}
}
