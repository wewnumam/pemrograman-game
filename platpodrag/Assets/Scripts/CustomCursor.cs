using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D mouseCursor;


    // Start is called before the first frame update
    void Start()
    {
        Vector2 hotSpot = new Vector2(0, 0);
        Cursor.SetCursor(mouseCursor, hotSpot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
