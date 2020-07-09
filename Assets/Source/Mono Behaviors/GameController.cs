using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;

    public Tile bushTile;
    public Tile dirtTile;
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
        for (int i = 0; i < 10; i++)
            SetTile(i, i, grassTile);
        for (int i = 0; i < 5; i++)
            SetTile(i, i + 1, dirtTile);
        SetTile(1, 3, bushTile);
        SetTile(1, 4, dirtTile);
        SetTile(1, 4, bushTile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
