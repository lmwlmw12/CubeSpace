using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObs : MoveableObs
 {

	// Use this for initialization
	void Start () {
        base.Init(20f);
        base.SetStrategies(new MoveSimple(this), new NotRotable());
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
        Move();
    }
}
