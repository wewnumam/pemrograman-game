using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetection : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    bool isFilled;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
         if (other.tag.Equals(gameObject.tag) && !isFilled)
         {
            Data.puzzleUnsolved--;
            Destroy(other.gameObject);
            spriteRenderer.color = Color.white;
            isFilled = true;
         }
    }
}
