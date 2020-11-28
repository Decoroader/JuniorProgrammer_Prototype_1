using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float vehicleSpeed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;

    void FixedUpdate()
    {
        // Move the vahicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput =   Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
