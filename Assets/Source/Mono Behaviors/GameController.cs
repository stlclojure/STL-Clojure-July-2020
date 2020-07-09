using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;

    public Tile grassTile;
    public Tile waterTile;

    public void Resize(int x, int y)
    {
        tilemap.size = new Vector3Int(x, y, 1);
    }

    public void SetTile(int x, int y, Tile tile)
    {
        if (0 <= x && x < tilemap.size.x && 0 <= y && y < tilemap.size.y)
            tilemap.SetTile(new Vector3Int(x, y, 0), tile);
    }

    public void FillWithTile(Tile tile)
    {
        for (int x = 0; x < tilemap.size.x; x++)
            for (int y = 0; y < tilemap.size.y; y++)
                SetTile(x, y, tile);
    }

    // Start is called before the first frame update
    void Start()
    {
        Resize(10, 10);
        FillWithTile(waterTile);
        SetTile(0, 0, grassTile);
        SetTile(1, 1, grassTile);
        SetTile(2, 2, grassTile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
