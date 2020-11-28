using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    public float vehicleSpeed = 5.0f;


    void FixedUpdate()
    {
        // Move the vahicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
