using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed; // speed of the airplane
    public float rotationSpeed; // plane rotation
    public float verticalInput; // movement of up and down
    public float horizontalInput; // movement of left and right

    void Start(){
    }

    void FixedUpdate(){
        verticalInput = Input.GetAxis("Vertical"); // gets the input to go up and down
        horizontalInput = Input.GetAxis("Horizontal"); // gets the input to go left and right

        transform.Translate(Vector3.forward * speed * Time.deltaTime); // makes the plane move forward

        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime); // moves the plane up or down depending on user input

        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime); // moves the plane left or right depending on the user input
    }
}
