using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 50;
    public float horizontalInput;
    private float verticalInput;

    public Camera mainCam;
    public Camera hoodCam;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turns the car on the Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


        if (Input.GetKeyDown(KeyCode.F))
        {
            mainCam.enabled = !mainCam.enabled;
            hoodCam.enabled = !hoodCam.enabled;
        }
    }
}