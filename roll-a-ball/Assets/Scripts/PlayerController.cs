using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the namespace required to use Unity UI and Input System
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Create public variables for player speed, and for the Text UI game objects
    public float speed = 0;
    public TextMeshProUGUI countText;
	public GameObject gameOverPanel;
    
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    // At the start of the game..
    void Start()
    {
        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();

        // Set the count to zero 
		count = 0;

		SetCountText();

        // Set the text property of the Win Text UI to an empty string, making the 'You Win' (game over message) blank
        gameOverPanel.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        // Create a Vector3 variable, and assign X and Z to feature the horizontal and vert
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        // Create a Vector3 variable, and assign X and Z to feature the horizontal and vertical float variables above
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("PickUp"))
		{
			other.gameObject.SetActive (false);

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText();
		}
	}

    void SetCountText()
	{
		countText.text = "Count: " + count.ToString();

		if (count >= 12) 
		{
            // Set the text value of your 'winText'
            gameOverPanel.SetActive(true);
		}
	}
}
