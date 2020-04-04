using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 100f;

    Rigidbody rigidBody;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // This get component only acts on components of type rigid body
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
        
    }

    // Private means only the code calls the function
    private void Rotate()
    {
        rigidBody.freezeRotation = true; // Takes manual control of the rotation

        float rotationThisFrame = rcsThrust * Time.deltaTime; // Use frametime here

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        rigidBody.freezeRotation = false; // Resumes physics control of rotation

    }

    private void Thrust()
    {
        float thrustThisFrame = mainThrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            // Thrusts while rotating
            rigidBody.AddRelativeForce(Vector3.up * thrustThisFrame);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
