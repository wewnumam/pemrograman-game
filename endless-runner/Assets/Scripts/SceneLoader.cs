using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int sceneOrder)
    {
        SceneManager.LoadScene(sceneOrder);
        DisplayScore.score = 0;
        DisplayScore.isGameOver = false;
    }
}
