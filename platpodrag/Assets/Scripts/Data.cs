using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    public static int keyTotal;
    public static int puzzleUnsolved;
    private static string replayScene;
    private static string nextScene;
    public GameObject keyParent;
    public GameObject puzzleDropParent;
    public string replaySceneName;
    public string nextSceneName;
    public static bool restart;
    private static float timer;

    // Start is called before the first frame update
    void Start()
    {
        keyTotal = keyParent.transform.childCount;
        puzzleUnsolved = puzzleDropParent.transform.childCount;
        replayScene = replaySceneName;
        nextScene = nextSceneName;
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleUnsolved == 0)
        {
            SceneManager.LoadScene(nextScene);
        }

        if (restart)
        {
            Time.timeScale = 0.1f;
            timer += Time.deltaTime;
            if (timer > 0.2)
            {
                Time.timeScale = 1;
                restart = false;
                timer = 0;
                SceneManager.LoadScene(replayScene);
            }
        }
    }
}
