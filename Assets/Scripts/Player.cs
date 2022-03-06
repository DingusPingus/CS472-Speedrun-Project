using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class handles the player movement with keyboard
//this scipt is largely based upon this tutorial: https://www.youtube.com/watch?v=_QajrabyTJc
public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3.0f;
    public float groundDistance = 0.4f;
    public float respawnHeight = -30;
    public Transform groundCheck;
   
    public LayerMask groundMask;

    Vector3 velocity;   
    bool isGrounded; 

    private void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //if you dont want to autojump
        //add to the if statement a check for Input.GetButtonDown("Jump")
        if( isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }

    void FixedUpdate(){
        //this was adapted from a unity forums post
        //located at this URL: https://answers.unity.com/questions/192906/Need-help-with-respawn-after-falling.html
        if(transform.position.y < respawnHeight){
            respawn();
        }
    }
    public void respawn(){
        transform.position = GameManager.respawnPoint;
    }

    
}
