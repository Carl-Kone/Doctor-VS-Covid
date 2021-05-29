using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    public CharacterController controller; // component to move the player

    public float speed = 6f; // speed of movement

    public Transform cam; // handles movement of the camera

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // getting horizontal input range from user
        float vertical = Input.GetAxis("Vertical");    // getting vertical input range from user 
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; // vector to store the direction of movement
        if (direction.magnitude >= 0.1f) // if there was an input
        {
            // dealing with the rotation of the player
            float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, targetangle, 0f);
      
            Vector3 moveDirection = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
            // move the player
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
        
    }

    private void Start()
    {
        //cam = FindObjectOfType<Camera>().transform;
        cam = GameObject.Find("Main Camera").transform;
    }
}
