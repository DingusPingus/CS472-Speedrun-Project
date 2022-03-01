using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class handles the player movement with keyboard
//this scipt is largely based upon this tutorial: https://www.youtube.com/watch?v=_QajrabyTJc
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    private void Start()
    {

    }

    void Update()
    {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;
       controller.Move(move * speed * Time.deltaTime);
    }
}
