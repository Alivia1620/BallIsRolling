using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //The player is destroyed when it collides with an enemy
            Destroy(gameObject);

            //Set the text to "You lose!"
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You lose!";
        }
    }

    //The movementValue will capture data from the x-and y-axis and store it
    //when the player presses the arrow keys or the WASD keys.
    void OnMove(InputValue movementValue)
    {
        //The function's body
        //The movementVector variable will store the data from the input 
        // system. The Get method will return the value of the input system.
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    //This method will update the text on the screen with the current count
    //of collectibles collected by the player.
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winTextObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // This method is called when the player collides with 
        // another object
        if (other.gameObject.CompareTag("Collectives"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        } 
    }
}
