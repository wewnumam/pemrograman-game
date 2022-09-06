using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    [SerializeField]
        private int force;
    [SerializeField]
        private Text textScoreWest;
    [SerializeField]
        private Text textScoreEast;
    [SerializeField]
        private Text textWinner;
    [SerializeField]
        private GameObject gameOverPanel;
    [SerializeField]
        private AudioClip hitSound;
    AudioSource audioSource;

    private Rigidbody2D ballRigidbody2D;
    private int scoreWest;
    private int scoreEast;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        ballRigidbody2D = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(2, Random.RandomRange(-2, 2)).normalized;
        ballRigidbody2D.AddForce(direction * force);
        audioSource = GetComponent<AudioSource>();
        
        scoreWest = 0;
        scoreEast = 0;

        gameOverPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        textScoreWest.text = scoreWest.ToString();
        textScoreEast.text = scoreEast.ToString();

        WinCondition(scoreWest, 5, "PLAYER BLUE");
        WinCondition(scoreEast, 5, "PLAYER RED");
    }

    private void ResetBallPosition()
    {
        transform.localPosition = new Vector2(0, 0);
        ballRigidbody2D.velocity = new Vector2(0, 0);
    }

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D other)
    {
        audioSource.PlayOneShot(hitSound);

        if (other.gameObject.name == "EdgeEast") {
            ResetBallPosition();
            Vector2 direction = new Vector2(2, Random.RandomRange(-2, 2)).normalized;
            ballRigidbody2D.AddForce(direction * force);

            scoreWest++;
        }

        if (other.gameObject.name == "EdgeWest") {
            ResetBallPosition();
            Vector2 direction = new Vector2(-2, Random.RandomRange(-2, 2)).normalized;
            ballRigidbody2D.AddForce(direction * force);

            scoreEast++;
        }

        if (other.gameObject.name == "PaddleEast" || other.gameObject.name == "PaddleWest") {
            float angle =(transform.position.y - other.transform.position.y) * 5f;
            Vector2 direction = new Vector2(ballRigidbody2D.velocity.x, angle).normalized;
            ballRigidbody2D.velocity = new Vector2(0, 0);
            ballRigidbody2D.AddForce(direction * force * 2);
        }

    }

    private void WinCondition(int playerScore, int score, string playerName)
    {
        if (playerScore == score) {
            gameOverPanel.SetActive(true);
            textWinner.text = playerName + " WIN!";
            Destroy(gameObject);
        }
    }

}
