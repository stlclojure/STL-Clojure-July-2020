using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;
    public Tile waterTile;

    public void Resize(int x, int y)
    {
        tilemap.size = new Vector3Int(x, y, 1);
    }

    public void FillWithTile(Tile tile)
    {
        for (int x = 0; x < tilemap.size.x; x++)
            for (int y = 0; y < tilemap.size.y; y++)
                tilemap.SetTile(new Vector3Int(x, y, 0), tile);
    }

    // Start is called before the first frame update
    void Start()
    {
        Resize(10, 10);
        FillWithTile(waterTile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
