using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    private float timer;
    private float randomSpawnTime;

    [SerializeField][Range(1,4)]
        private float maxSleepTime;
    [SerializeField]
        private GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        randomSpawnTime = Random.Range(1, maxSleepTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > randomSpawnTime)
        {
            int elementIndex = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[elementIndex], transform.position, transform.rotation);

            randomSpawnTime = Random.Range(2, maxSleepTime);
            timer = 0;
        }
    }
}
