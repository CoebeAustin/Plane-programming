using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed; // speed of rotation of the obstacle
    void Start()
    {
    }

    void Update() // makes the obstacle rotate on the z-axis
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
