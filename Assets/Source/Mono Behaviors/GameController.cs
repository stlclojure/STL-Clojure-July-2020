using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;

    public void Resize(int x, int y)
    {
        Debug.Log("tilemap size was " + tilemap.size);
        tilemap.size = new Vector3Int(x, y, 1);
        Debug.Log("tilemap size is now " + tilemap.size);
    }

    // Start is called before the first frame update
    void Start()
    {
        Resize(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
