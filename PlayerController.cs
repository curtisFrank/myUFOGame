//*************************************************************************
// Name: PlayerController.cs
// Programmer: Curtis Frank
// Date: 5/14/2016
//*************************************************************************

using UnityEngine;
using System.Collections;
using UnityEngine.UI;   // needed for UI text elements

public class PlayerController : MonoBehaviour 
{
    // variable
    public float speed;

    // text elements
    public Text countText;
    public Text winText;

    // Rigidbody2D object
    private Rigidbody2D rb2d;

    // counter
    private int count;

    // initialization******************************************************
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";

        // call the text update function
        UpdateText();
    }

    // physics update******************************************************
    void FixedUpdate()
    {
        // get arrow key input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Vector2 object
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // apply forces to RigidBody2D
        rb2d.AddForce(movement * speed);
    }

    // pickup trigger collision function***********************************
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
            other.gameObject.SetActive(false);

        // increment counter
        count++;

        // call the text update function
        UpdateText();

        if (count >= 12)
            winText.text = "You Win";
    }

    // text update function************************************************
    void UpdateText()
    {
        countText.text = string.Format("Count: {0}",
                                       count.ToString());
    }
}
