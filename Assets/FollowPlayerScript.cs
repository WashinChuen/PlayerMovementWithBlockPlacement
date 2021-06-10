using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    void Update()
    {
        this.transform.position = PlayerBlockManagerScript.blockManager.GetPlayerPosWithOffset();
    }
}
