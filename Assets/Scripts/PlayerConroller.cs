using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PlayerConroller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;

    [SerializeField] private float horsePower = 300999.0f;
    [SerializeField] private float turnSpeed = 55.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody vehicleRb;
    [SerializeField]private GameObject centerOfMass;

    private float speed;
    private float rpm;

    [SerializeField]private List<WheelCollider> allWheels;
    //private int wheelsOnGround;
    [SerializeField]private int wheelsOnGround;

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

        if (IsOnGround())
        {
            // Move the vehicle forward
            //vehicleRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
            foreach (var wheel in allWheels)
            {
                wheel.motorTorque = horsePower * verticalInput;
            }

            // turn the vehicle right-left
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

            speed = Mathf.Round(vehicleRb.velocity.magnitude * 3.6f); // 2.37f mph
            speedometerText.SetText("Speed: " + speed + " kph");
            rpm = (speed % 30) * 40;
            rpmText.SetText("RPM: " + rpm);
        }
    }

    private bool IsOnGround()
	{
        wheelsOnGround = 0;
		foreach (WheelCollider wheel in allWheels)
		{
            if (wheel.isGrounded)
                wheelsOnGround++;
		}
        if (wheelsOnGround >= 2)
            return true;
        else 
            return false;
	}
}
