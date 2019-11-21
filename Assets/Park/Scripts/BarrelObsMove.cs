using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelObsMove : MoveableObs {
    public float arrived;
    // Use this for initialization
	void Start () {
        base.Init(10f);
        base.SetStrategies(new MoveSimple(this), new Rotable(this, 55f));
        firstPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        base.Rotate();
        base.Move();
        if (transform.localPosition.x > arrived)
        {
            transform.position = firstPos;
        }
    }
}
