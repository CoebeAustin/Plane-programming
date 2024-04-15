using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovementLR : MonoBehaviour{

    [SerializeField] private float speed; // speed of rotation
    [SerializeField] private float moveDistance; // limitations of distance 
    private bool movingRight = true;

    void Start(){
    }

    void Update(){
        if (movingRight){ // moves the obstacle to the right
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else{ // moves the obstacle to the left
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
}
