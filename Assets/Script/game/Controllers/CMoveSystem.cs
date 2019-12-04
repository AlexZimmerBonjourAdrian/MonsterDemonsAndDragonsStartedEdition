using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMoveSystem : MonoBehaviour
{
    //====Cambiar de estados
    private bool _AirControl = true;
    private bool _Ground = false;
    //=====

    private const float MaxSpeed = 30f;
    [SerializeField] private float _JumpForce = 30f;

    [Range(0, 3f)] [SerializeField] private float _MovementSmoothing = .95f;
    private const float _MinjumpForce = 2f;
    private const float _MaxJumpForce = 30f;
    private Rigidbody2D rigidboy2D;
    private Vector3 _velocity = Vector3.zero;
    private bool _FacingRight = true;
    [SerializeField] private Transform _GroundCheck;

    [SerializeField] private Transform _CeilingCheck;
    [SerializeField] private LayerMask _WhatisGround ;
    [SerializeField] private LayerMask _PlayerLayer;
    [SerializeField] private LayerMask _platformLayer;

    bool jumpoffCourutineIsRunning = false;
    

    
    const float _CillingRadius = .5f;
    const float _GroundedRadius = .5f;
    
    //private const int STATE_STAND= 0;
    //private const int STATE_MOVE = 1;
    //private const int STATE_JUMP = 2;
    //private const int STATE_RUN = 3;
    //private const int STATE_FALL = 4;
    //private const int STATE_COUCH = 5;

    // Start is called before the first frame update

    private void Awake()
    {
        rigidboy2D = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame

    private void FixedUpdate()
    {
        
        _Ground = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(_GroundCheck.position, _GroundedRadius, _WhatisGround);
        
        for (int i = 0; i < colliders.Length; i++)
        {
            
            if (colliders[i].gameObject != gameObject)
            {
                
                _Ground = true;
            }
        }

        

        
    }
    
    public void MovePlayer(float move, bool jump)
    {
        if (_Ground || _AirControl)
        {


            //===========================================MoveFunction
            Vector3 targetVelocity = new Vector3(move * 10f, rigidboy2D.velocity.y);
            rigidboy2D.velocity = Vector3.SmoothDamp(rigidboy2D.velocity, targetVelocity, ref _velocity, _MovementSmoothing);
            //=======================================


            //==============================Flip condition
            if (move > 0 && !_FacingRight)
            {
                Flip();
            }
            else if (move < 0 && _FacingRight)
            {
                Flip();
            }
            //=====================================

            //=============================Jump Part
        }


        if (_Ground && jump)
        {
            _Ground = false;
            rigidboy2D.AddForce(new Vector2(0f, _JumpForce));
        }
        //=============================
    }
    //public void incrementVelDown(float DownForz)
    //{
    //    this.transform.position = new Vector2(Vector2.zero.x, this.transform.position.y - (DownForz * Time.deltaTime));
    //}
    //public void incrementGravDown(float DownForce)
    //{
    //    rigidboy2D.gravityScale=DownForce;
    //}
    //public void DashDown(float dashForce)
    //{
    //    rigidboy2D.AddForce(new Vector2(0f, _JumpForce));
    //}

    //FLIP del personaje basico ajustar despues, para crear 
    private void Flip()
    {
        _FacingRight = !_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    //==============================================
    
  
   

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_GroundCheck.position, _GroundedRadius);
        Gizmos.DrawWireSphere(_CeilingCheck.position, _GroundedRadius);
    }
    
    IEnumerator jumpOff()
    {
        jumpoffCourutineIsRunning = true;
        Physics2D.IgnoreLayerCollision(_PlayerLayer, _platformLayer, true);
        yield return new WaitForSeconds(0.5f);
        Physics2D.IgnoreLayerCollision(_PlayerLayer, _platformLayer, false);
        jumpoffCourutineIsRunning = false;

    }
    private void JumpOff()
    {
        
    }
  
}


    /*
        private void Update()
        {
            Debug.Log(_Ground);
        }
       /*
        private void OnCollisionEnter2D(Collision2D gamecolision)
        {
            if(gamecolision.gameObject.tag == "Floor")
            {
                Debug.Log("Entra");
                _Ground = true;
                _AirControl = false;
            }
        }
        */
 



