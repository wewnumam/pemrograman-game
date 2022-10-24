using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text keyTotalText;
    public Text puzzleUnsolvedText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Data.keyTotal == 0)
            keyTotalText.text = "Key Total: COMPLETE";
        else 
            keyTotalText.text = "Key Total: " + Data.keyTotal.ToString();
        
        if (Data.puzzleUnsolved == 0)
             puzzleUnsolvedText.text = "Puzzle Unsolved: COMPLETE";
        else
            puzzleUnsolvedText.text = "Puzzle Unsolved: " + Data.puzzleUnsolved.ToString();
    }
}
