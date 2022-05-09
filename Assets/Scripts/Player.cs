using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;

    public Vector3 movement;

    float Speed = 1;


    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //Debug.Log(Input.GetAxis("Horizontal"));
        movement.x = Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Vertical"));
        movement.z = Input.GetAxis("Vertical");

        if (controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                movement.y = 10;

            }

        }
        else
        {
            movement.y -= 0.1f;
        }
    }
    void FixedUpdate()
    {

        controller.Move(movement * Speed * Time.fixedDeltaTime);


    }

}