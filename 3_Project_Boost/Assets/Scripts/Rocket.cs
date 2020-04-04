using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // This get component only acts on components of type rigid body
        rigidBody = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        
    }

    // Private means only the code calls the function
    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Thrusts while rotating
            print("Thrusting");
            rigidBody.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left");
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
            transform.Rotate(-Vector3.forward);
        }
    }
}
