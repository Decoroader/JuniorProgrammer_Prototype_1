using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float vehicleSpeed = 5.0f;
    public float turnSpeed;

    void FixedUpdate()
    {
        // Move the vahicle forward
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
