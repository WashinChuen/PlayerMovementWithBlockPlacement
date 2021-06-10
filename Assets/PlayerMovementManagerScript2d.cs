using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManagerScript2d : MonoBehaviour
{
    [SerializeField]
    PlayerControlScript2d playerControl;

    private bool canMove = true;

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
            return;
        playerControl.MovePlayer(GetPlayerVelocity());
    }
    public Vector2 GetPlayerVelocity()
    {
        Vector2 playerVelocity
        = new Vector2(Input.GetAxisRaw("Horizontal"),
                      Input.GetAxisRaw("Vertical"));

        playerControl.ChangePlayerFacingDirection(playerVelocity);

        return playerVelocity;
    }

    public Vector3 GetPlayerScale()
    {
        return playerControl.GetPlayerScale();
    }

    public void CanMove(bool _canMove)
    {
        canMove = _canMove;
    }

}