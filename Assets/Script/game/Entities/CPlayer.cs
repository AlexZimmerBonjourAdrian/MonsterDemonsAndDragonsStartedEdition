using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour
{
   private CMoveSystem controller;
    [SerializeField]private float _Speed =200f;
     float horizontalMove = 3;
    bool jump = false;
    [SerializeField]private float DelayStateFall = 1f;
    private const int STATE_STAND = 0;
    private const int STATE_MOVE = 1;
    private const int STATE_JUMP = 2;
    private const int STATE_FALL = 3;
    [HideInInspector]private int _aState = 0;
    [SerializeField]private float _dashSpeed = 30f;

   
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CMoveSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Estado" + _aState);
        if (Input.GetButton("Horizontal"))
        {
            setState(STATE_MOVE);
        }
        else if(!Input.GetButton("Horizontal"))
        {
            setState(STATE_STAND);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jump == false ) 
        {
           
            setState(STATE_JUMP);
        }

        if(_aState==STATE_JUMP)
        {
            for (float i = DelayStateFall*Time.deltaTime; i > 0; i--)
            {
                if (i == DelayStateFall)
                {

                    setState(STATE_FALL);
                }
            }
        }

    }
    void FixedUpdate()
    {
        
        jump = false;
    }
    private void setState(int aState)
    {
        _aState = aState;
        
        if(aState== STATE_STAND)
        {

        }
        else if(aState == STATE_MOVE)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * _Speed;
            controller.MovePlayer(horizontalMove * Time.deltaTime, jump);
        }
        else if(aState == STATE_JUMP)
        {
            
            jump = true;
            controller.MovePlayer(horizontalMove * Time.deltaTime, jump);
            
          
            
        }
        else if(aState== STATE_FALL)
        {
            
        }
        
    }
    
}
