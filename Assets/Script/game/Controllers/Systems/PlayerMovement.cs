using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;
	private Rigidbody2D _rigidbody2D;
	float horizontalMove = 0f;
	bool jump = true;
	bool crouch = false;
	private const int STAND_STATE= 0;
	private const int RUN_STATE= 1;
	private const int JUMP_STATE = 2;
	private const int DASH_STATE = 3;
	private int _state = 0;

	//private ControllerWeapond  

	private void Awake()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetButton("Horizontal"))
		{
			//setState(RUN_STATE);
		}
		else if(!Input.GetButton("Horizontal"))
		{
			//setState(STAND_STATE);
		}
		*/
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		animator.SetFloat("SpeedY", _rigidbody2D.velocity.y);

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
			
			
		}
		/*
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
		*/


	}
	
	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
		
	}
	
	/*
	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}
	*/
	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
    #region Dash 

	

    #endregion

    #region Armas

    #endregion
    /*
	void setState( int aState)
	{
		aState = _state;
		if(aState== STAND_STATE)
		{
			
		}
		else if(aState == RUN_STATE)
		{

		}
		else if(aState == JUMP_STATE)
		{
		}
		else if(aState == d)
	}
	
	void setExitState(int aState)
	{
		if(aState == STAND_STATE)
		{

		}
	}
	*/
	
}
