using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManagerScript : MonoBehaviour
{
    [SerializeField]
    PlayerControlsScript playerControls;

    [SerializeField]
    public bool canMove = true;
    int moveUp = 0;

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
            return;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveUp = 1;
            playerControls.MovePlayerUp(moveUp);
        }




        moveUp = 0;
        playerControls.MovePlayer(GetPlayerVelocity());

    }

    public Vector3 GetPlayerVelocity()
    {
        int jumpVec = 0;

        Vector3 playerVelocity = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            jumpVec = Input.GetKeyDown(KeyCode.Space) ? 1 : 0,
            Input.GetAxisRaw("Vertical"));
        return playerVelocity;
    }




}
