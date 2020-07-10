using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public Grid grid;

    public Tilemap vegetationTilemap;
    public Tilemap worldTilemap;

    public Tile bushTile;
    public Tile dirtTile;
    public Tile grassTile;
    public Tile waterTile;

    public void Resize(int x, int y)
    {
        vegetationTilemap.size = worldTilemap.size = new Vector3Int(x, y, 1);
    }

    public void SetTile(int x, int y, Tile tile)
    {
        if (0 <= x && x < worldTilemap.size.x && 0 <= y && y < worldTilemap.size.y)
            worldTilemap.SetTile(new Vector3Int(x, y, 0), tile);
    }

    public void SetVegetation(int x, int y, Tile tile)
    {
        if (0 <= x && x < vegetationTilemap.size.x && 0 <= y && y < vegetationTilemap.size.y)
            vegetationTilemap.SetTile(new Vector3Int(x, y, 0), tile);
    }

    public void FillWithTile(Tile tile)
    {
        for (int x = 0; x < worldTilemap.size.x; x++)
            for (int y = 0; y < worldTilemap.size.y; y++)
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
        SetTile(1, 3, dirtTile);
        SetVegetation(1, 3, bushTile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
