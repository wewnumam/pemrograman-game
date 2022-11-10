using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayText : MonoBehaviour
{
    public Text timeText;
    public Text bestTimeText;
    
    // Start is called before the first frame update
    void Start()
    {
        bestTimeText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = String.Format("Time: {0} \nBest Time: {1}", Mathf.Floor(Data.timer), Mathf.Floor(Data.bestTime));
        if (Data.isBestTime)
            bestTimeText.gameObject.SetActive(true);
        else
            bestTimeText.gameObject.SetActive(false);
    }
}
