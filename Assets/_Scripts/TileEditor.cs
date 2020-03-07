using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileEditor : MonoBehaviour
{

    public Tilemap worldGround;
    public Tilemap worldObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = worldObject.layoutGrid.WorldToCell(pos);

            worldObject.SetTile(cellPosition, Hotbar.setTile);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = worldObject.layoutGrid.WorldToCell(pos);
            
            worldObject.SetTile(cellPosition, null);
        }
    }
}
