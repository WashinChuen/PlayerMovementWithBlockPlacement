using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlockManagerScript : MonoBehaviour
{
    public static PlayerBlockManagerScript blockManager;

    [SerializeField]
    PlayerPlaceBlockControlScript playerBlockControls;

    [SerializeField]
    PlayerMovementManagerScript2d playerMoveManager;

    [SerializeField]
    GameObject playerGameObject;

    Vector3 defaultOffset = new Vector3(400, 0);
    Vector3 changedOffset;

    private bool canMoveBlock = false;

    private void Awake()
    {
        if (blockManager == null)
            blockManager = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartPlacingBlock();

        if (Input.GetKeyUp(KeyCode.Space))
            EndPlacingBlock();

        if (canMoveBlock)
            ChangeOffset();
    }

    private void EndPlacingBlock()
    {
        playerMoveManager.CanMove(true);
        canMoveBlock = false;
        playerBlockControls.RemoveBlockPlacementPreview();
        playerBlockControls.PlaceBlock();
    }

    private void StartPlacingBlock()
    {
        playerMoveManager.CanMove(false);
        canMoveBlock = true;
        changedOffset = defaultOffset;
        playerBlockControls.SpawnBlockPlacementPreview();
    }

    public Vector3 GetPlayerPosWithOffset()
    {
        Vector3 playerPos = playerGameObject.transform.position;
        playerPos += GetOffset() * playerMoveManager.GetPlayerScale().x;
        return playerPos;
    }

    public void ChangeOffset()
    {
        if (playerMoveManager.GetPlayerScale().x == 1)
            changedOffset += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        else
            changedOffset -= new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    public Vector3 GetOffset()
    {
        return changedOffset;
    }

}
