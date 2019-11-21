using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveableObs : MonoBehaviour {
    private bool passedFlag;
    private bool disActiveFlag;
    private bool activeFlag;
    public float speed;
    [SerializeField]
    public Vector3 firstPos;
    private GameObject playerObj;
    private string playerName = "Player";
    private IRotable rotateStrategy;
    private IMoveable moveStrategy;

    protected void Init(float speed) {
        passedFlag = false;
        activeFlag = false;
        disActiveFlag = false;
        playerObj = GameObject.Find(playerName);
        this.speed = speed;
    }
    protected void SetStrategies(IMoveable moveStrategy, IRotable rotateStrategy)
    {
        SetMoveStrategy(moveStrategy);
        SetRotateStrategy(rotateStrategy);
    }
    public Vector3 GetPlayerPos()
    {
        return playerObj.transform.position;
    }
    public Quaternion GetPlayerRot()
    {
        return playerObj.transform.rotation;
    }
    protected void Move()
    {
        moveStrategy.Move();
    }
    protected void Rotate()
    {
        rotateStrategy.Rotate();
    }
    private void SetRotateStrategy(IRotable rotateStrategy)
    {
        this.rotateStrategy = rotateStrategy;
    }
    private void SetMoveStrategy(IMoveable moveStrategy)
    {
        this.moveStrategy = moveStrategy;
    }
}
