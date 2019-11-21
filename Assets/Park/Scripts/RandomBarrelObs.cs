using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBarrelObs : MoveableObs {

	// Use this for initialization
	void Start () {
        float scale = Random.Range(1f, 10f);
        transform.position += new Vector3(0f, 0.23f * scale, 0f);
        base.Init(Random.Range(15f, 25f));
        base.SetStrategies(new MoveSimple(this), new Rotable(this, 55f));
        transform.localScale = new Vector3(scale, scale, scale);
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
        Move();
    }
}
