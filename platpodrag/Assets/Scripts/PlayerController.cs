using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    public float jumpForce = 200;
    Rigidbody2D rb;
    bool isGround;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
        
        if (Input.GetAxis("Horizontal") < 0)
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);

        if (Input.GetAxis("Jump") > 0 && isGround)
        {
            rb.AddForce(new Vector2(0, 1) * jumpForce);
            isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }

        if (other.gameObject.CompareTag("Ball"))
        {
            Data.restart = true;
        }
    }
}
