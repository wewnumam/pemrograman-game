using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    public float jumpForce = 200;
    Rigidbody2D rb;
    float inputX;
    float inputY;
    bool isJump = true;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Jump");
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(inputX, 0);
        rb.AddForce(movement * speed);

        if (inputY > 0 && !isJump)
            rb.AddForce(new Vector2(0, 1) * jumpForce);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (isJump)
            isJump = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isJump = true;
    }
}
