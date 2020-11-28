using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // Move the vahicle forward
        transform.Translate(Vector3.forward * Time.deltaTime*20f);
    }
}
