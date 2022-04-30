using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //Chodzenie i patrzenie
    public CharacterController controller;
    public Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    //Grawitacja
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    //skakanie
    public float jumpHeight = 3f;
    private bool canDoubleJump = false;
    public int numberOfJumps = 2;

    private float coyoteTime = 1f;
    private float coyoteTimeCounter;

    private float jumpBufferTime = 0.2f;
    private float jumpBufferCounter;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
      
        //chodzenie i patrzenie
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        //grawitacja
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        



        //skakanie
        if ((jumpBufferCounter > 0f) && (coyoteTimeCounter > 0))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpBufferCounter = 0f;
            canDoubleJump = true;




        }
        if (Input.GetButtonUp("Jump") && velocity.y > 0f)
        {
            coyoteTimeCounter = 0f;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity) * 0.5f;
        }
        //skok po zbiegnieciu z platformy
        if (isGrounded)
        {
            coyoteTimeCounter = coyoteTime;
            canDoubleJump = true;

        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }
        //podwójne skakanie
      
        if (Input.GetButtonDown("Jump"))
        {
            jumpBufferCounter = jumpBufferTime;
        }
        else
        {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump") && !isGrounded && (canDoubleJump == true))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            canDoubleJump = false;
        }

        if (Input.GetButtonDown("Jump"))
            {
            
        }

    }
}
