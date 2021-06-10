using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsScript : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void MovePlayer(Vector3 moveVec)
    {
        //rb.velocity += moveVec;
        rb.AddForce(moveVec);
    }


    public void MovePlayerUp(int movePlayerUpByThisInt)
    {
        this.transform.position += new Vector3(0, movePlayerUpByThisInt);
    }


}
