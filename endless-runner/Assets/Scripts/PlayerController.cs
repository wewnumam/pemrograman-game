using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
        private float jumpForce;
    
    private bool isLevelGravitySwitcher;
    private Rigidbody rb;
    private bool isGrounded;

    [SerializeField]
        private GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        gameOverPanel.SetActive(false);

        if (SceneManager.GetActiveScene().name == "LevelGravitySwitcher")
            isLevelGravitySwitcher = true;
        else
            isLevelGravitySwitcher = false;
    }

    private void OnCollisionStay(Collision other) 
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            if (isLevelGravitySwitcher)
                Physics.gravity *= -1;
        }
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag.Equals("Obstacle"))
        {
            gameOverPanel.SetActive(true);
            DisplayScore.isGameOver = true;
        }
    }
}
