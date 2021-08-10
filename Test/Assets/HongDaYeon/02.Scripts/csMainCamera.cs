using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMainCamera : MonoBehaviour
{
    public float movSpeed = 5f;
    public float rotSpeed = 120f;

    CharacterController controller;
    Vector3 moveDirection;

    float jumpSpeed = 10f;
    float gravity = 20f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (controller.isGrounded)
        {
            float amtRot = rotSpeed * Time.deltaTime;

            float ver = Input.GetAxis("Vertical");
            float ang = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up * ang * amtRot);

            moveDirection = new Vector3(0, 0, ver * movSpeed);
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
