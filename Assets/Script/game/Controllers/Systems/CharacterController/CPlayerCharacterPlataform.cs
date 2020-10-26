using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerCharacterPlataform : CPhysicsObject
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    private SpriteRenderer spriteRenderer;
    //private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //animator = GetComponent<Animator>();

    }
    protected override void ComputerVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && grounded)
        {
            if(velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }
        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if(flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        //animator.SetBool("Grounded", grounded);
        //animator.SetFloat("VelocityX", Mathf.Abs(velocity.x) / maxSpeed);

        targetVelocity = move * maxSpeed;
    }
}
