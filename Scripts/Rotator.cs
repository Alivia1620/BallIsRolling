using UnityEngine;

public class Rotator : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        // The transform.Rotate method rotates the object around 
        // the specified axis
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); 
    }
}
