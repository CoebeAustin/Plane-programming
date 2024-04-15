using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset; // Offset to position the camera behind the player

    void Update()
    {
        // Calculate the target position for the camera (behind the player)
        Vector3 targetPosition = plane.transform.position + plane.transform.TransformDirection(offset);

        // Set the camera's position to the target position
        transform.position = targetPosition;

        // Make the camera look at the player
        transform.LookAt(plane.transform.position);
    }
}
