using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSpawner : MonoBehaviour
{
    bool isSpawn;
    float timer;
    public float pause = 2f;
    public GameObject[] puzzles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawn)
        {
            timer += Time.deltaTime;
            if (timer > pause)
            {
                int random = Random.Range(0, puzzles.Length);
                Instantiate(puzzles[random], transform.position, transform.rotation);
                timer = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player") && Data.keyTotal == 0)
            isSpawn = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
            isSpawn = false;
    }
}
