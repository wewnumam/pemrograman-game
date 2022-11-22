using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    public float jumpForce = 200;
    Rigidbody2D rb;
    bool isGround;
    Animator animator;
    SpriteRenderer spriteRenderer;
    enum MoveCondition { Idle, Left, Right }
    MoveCondition currentMove;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
         spriteRenderer = GetComponent<SpriteRenderer>();
         currentMove = MoveCondition.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) MoveLeft();
        if (Input.GetKeyDown(KeyCode.RightArrow)) MoveRight();
        if (Input.GetKeyUp(KeyCode.RightArrow)) Idle();
        if (Input.GetKeyUp(KeyCode.LeftArrow)) Idle();
        if (Input.GetAxis("Jump") > 0 && isGround) Jump();
        
        Move();
    }

    public void MoveLeft() {
        currentMove = MoveCondition.Left;
    }

    public void MoveRight() {
        currentMove = MoveCondition.Right;
    }

    public void Idle() {
        currentMove = MoveCondition.Idle;
    }

    public void Jump() {
        if (isGround) {
            rb.AddForce(new Vector2(0, 1) * jumpForce);
            isGround = false;
        }
    }

    private void Move() {
        if (currentMove == MoveCondition.Left) {
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
            animator.SetTrigger("run");
            spriteRenderer.flipX = true;
        }
        if (currentMove == MoveCondition.Right) {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
            animator.SetTrigger("run");
            spriteRenderer.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground"))
            isGround = true;

        if (other.gameObject.CompareTag("Ball"))
            Data.restart = true;
    }

    private void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground"))
            if (currentMove == MoveCondition.Idle)
                animator.SetTrigger("idle");
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Ground"))
            animator.SetTrigger("jump");
    }
}
