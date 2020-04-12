using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerLoop : PlayerMovement
{
    //public CharacterController2D controller;
    //public Animator animator;

    //public float runSpeed = 40f;
    private Rigidbody2D _rigidbody2D;
    private float _horizontalMove = 0f;
    private bool jump = true;
    private bool crouch = false;
    private const int STAND_STATE = 0;
    private const int RUN_STATE = 1;
    private const int JUMP_STATE = 2;
    //private int _state = 0;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
    // Update is called once per frame
    void Update()
   {
        _horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        /*
        animator.SetFloat("Speed", Mathf.Abs(_horizontalMove));
        animator.SetFloat("SpeedY", Mathf.Abs(_horizontalMove));
        */
        
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            //animator.SetBool("IsJumpimg", true);
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            Destroy(gameObject);
        }
    }
    /*
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    */
    private void FixedUpdate()
    {
        controller.Move(_horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    /*
    void setState(int aState)
    {

    }
    */
}
