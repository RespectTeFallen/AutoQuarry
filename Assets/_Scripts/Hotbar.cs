using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Hotbar : MonoBehaviour
{

    public List<GameObject> slots;
    public List<Tile> tiles;
    public static Tile setTile;

    void Start()
    {
        setTile = tiles[0];
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            setTile = tiles[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            setTile = tiles[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            setTile = tiles[2];
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            setTile = tiles[3];
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            setTile = tiles[4];
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            setTile = tiles[5];
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            setTile = tiles[6];
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            setTile = tiles[7];
        }
    }
}
