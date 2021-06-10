using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript2d : MonoBehaviour
{
    Rigidbody2D rd2d;
    private void Awake()
    {
        rd2d = this.GetComponent<Rigidbody2D>();
    }
    public void MovePlayer(Vector2 moveVec)
    {

        this.transform.position += new Vector3(moveVec.x, moveVec.y);
        //rd2d.velocity += moveVec;
        //rd2d.AddForce(moveVec * 5, ForceMode2D.Impulse);
        //Debug.Log("movedPlayer");
    }

    public Vector3 GetPlayerScale()
    {
        return this.transform.localScale;
    }

    public void ChangePlayerFacingDirection(Vector3 scaleXValue)
    {
        Debug.Log(scaleXValue);
        if (scaleXValue.x == 0)
        {
            return;
        }
        Vector3 scale = new Vector3(scaleXValue.x, 1, 1);
        this.transform.localScale = scale;
    }
}