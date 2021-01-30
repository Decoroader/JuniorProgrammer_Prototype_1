using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed = new Vector3(0, 0, 45.0f);
    

    void FixedUpdate()
    {
        transform.Rotate(rotationSpeed);
    }
}
