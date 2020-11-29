using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    private float vehicleSpeed = 9.0f;
    private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float verticalInput;

    void FixedUpdate()
    {
        // control by player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput =   Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
        // turn the vehicle right-left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
