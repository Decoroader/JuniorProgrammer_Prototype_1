using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    [SerializeField] private float horsePower = 300999.0f;
    [SerializeField] private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody vehicleRb;
    [SerializeField]private GameObject centerOfMass;


    private void Start()
	{
        vehicleRb = GetComponent<Rigidbody>();
        vehicleRb.centerOfMass = centerOfMass.transform.position;

    }

	void FixedUpdate()
    {
        // control by player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput =   Input.GetAxis("Vertical");

        // Move the vehicle forward
        //transform.Translate(Vector3.forward * horsePower * verticalInput);
        vehicleRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // turn the vehicle right-left
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
