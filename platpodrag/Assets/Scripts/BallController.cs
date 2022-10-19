using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float force;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(-5f, 5f);
        rb.AddForce(movement * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
