using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    private Vector3 offset; // Offset distance between the player and camera

    // Start is called once before the first execution of Update after 
    // the MonoBehaviour is created
    void Start()
    {
        // Calculate the initial offset between the camera and player
        offset = transform.position - player.transform.position; 
       
    }

    // Update is called once per frame
    // LateUpdate is called after all Update functions have been called
    // This is useful for following the player after all other updates
    void LateUpdate()
    {
        // Update the camera position to follow the player
        transform.position = player.transform.position + offset;
    }
}
