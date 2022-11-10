using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointContainer : MonoBehaviour
{
    int currentCheckpoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (CheckpointController checkpoint in this.GetComponentsInChildren<CheckpointController>())
        {
            checkpoint.onHitByPlayer = (int checkpointId) => OnReachCheckpoint(checkpointId);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnReachCheckpoint(int checkpointId)
    {
        if (checkpointId == currentCheckpoint + 1) {
            currentCheckpoint++;
        }
        else if (checkpointId == 1 && currentCheckpoint == 4) {
            if (Data.timer < Data.bestTime)
            {
                Data.bestTime = Data.timer;
                Data.isBestTime = true;
            }
            currentCheckpoint = 1;
            Data.timer = 0;
        }
    }
}
