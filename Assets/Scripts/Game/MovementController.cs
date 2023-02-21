using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM 
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
#endif

public class MovementController : MonoBehaviour
{
    public CharacterController controller;
    public Animator anim;
    public float forwardSpeed;
    public float sideSpeed;
    public float jumpForce = 5f;
    public float gravity = -20;

    

    private Vector3 direction;

    //int isRunningHash;
    ////int isJumpingHash;
    
    
    private void Start()
    {
        
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
    private void Update()
    {
       
        float x = Input.GetAxis("Horizontal") * sideSpeed;
        
        direction.z = forwardSpeed;
        anim.SetFloat("running", forwardSpeed);
        direction.x = x;
        direction.y += gravity * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }

    private void Jump()
    {
        direction.y = jumpForce;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }
    
}
