using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlaceBlockControlScript : MonoBehaviour
{
    [SerializeField]
    Transform blockHolderTransform;
    [SerializeField]
    GameObject blockPrefab;
    [SerializeField]
    GameObject previewBlockPrefab = null;
    int blockOffset = 400;
    GameObject previewBlock = null;

    private void Awake()
    {
        previewBlock = Instantiate(previewBlockPrefab, this.transform);
        previewBlock.SetActive(false);
    }

    public void PlaceBlock()
    {
        Instantiate(blockPrefab, PlayerBlockManagerScript.blockManager.GetPlayerPosWithOffset(), Quaternion.identity, blockHolderTransform);
    }

    public void SpawnBlockPlacementPreview()
    {
        previewBlock.SetActive(true);
    }

    public void RemoveBlockPlacementPreview()
    {
        previewBlock.SetActive(false);
    }
}
