using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float vehicleSpeed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    void FixedUpdate()
    {
        // Move the vahicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
