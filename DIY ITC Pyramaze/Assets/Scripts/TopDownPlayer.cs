
using UnityEngine;

public class TopDownPlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // What Moves Us
        float horizontalInput = Input.GetAxis("Horizontal");

        //Get the value of the Horizontal input axis.
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, verticalInput, and 0 respectively.
    }
}
