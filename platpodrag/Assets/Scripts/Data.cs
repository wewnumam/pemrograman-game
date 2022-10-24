using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    public static int keyTotal;
    public static int puzzleUnsolved;
    private static string replayScene;
    public GameObject keyParent;
    public GameObject puzzleDropParent;
    public string replaySceneName;


    // Start is called before the first frame update
    void Start()
    {
        keyTotal = keyParent.transform.childCount;
        puzzleUnsolved = puzzleDropParent.transform.childCount;
        replayScene = replaySceneName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Replay()
    {
        SceneManager.LoadScene(replayScene);
    }
}
