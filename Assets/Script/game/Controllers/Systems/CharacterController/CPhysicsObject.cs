using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPhysicsObject : MonoBehaviour
{
    public float minGroundNormalY = .65f;
    public float gravitymodifier = 1f;

    protected Vector2 targetVelocity;
    protected bool grounded;
    protected Vector2 groundNormal;
    protected Rigidbody2D rb2d;
    protected Vector2 velocity;
    protected ContactFilter2D contactFilter;
    protected RaycastHit2D[] hitBuffer = new RaycastHit2D[16];
    protected List<RaycastHit2D> hitbufferList = new List<RaycastHit2D>(16);

    protected const float minMoveDistance = 0.001f;
    protected const float shellRdaius = 0.01f;

    private void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        contactFilter.useTriggers = false;
        contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));
        contactFilter.useLayerMask = true;
    }

    private void Update()
    {
        targetVelocity = Vector2.zero;
        ComputerVelocity();
    }
    protected virtual void ComputerVelocity()
    {

    }

    private void FixedUpdate()
    {
        velocity += gravitymodifier * Physics2D.gravity * Time.deltaTime;
        velocity.x = targetVelocity.x;
        grounded = false;
        Vector2 deltaPosition = velocity * Time.deltaTime;

        Vector2 moveAlongGround = new Vector2(groundNormal.y, - groundNormal.x);
        Vector2 move = moveAlongGround * deltaPosition.x;
        Movement(move, false);
        move = Vector2.up * deltaPosition.y;
        Movement(move, true);
    }
    void Movement(Vector2 move, bool yMovement)
    {
        float distance = move.magnitude;
        if(distance > minMoveDistance)
        {
            int count = rb2d.Cast(move, contactFilter, hitBuffer, distance + shellRdaius);
            for(int i = 0; i < count; i++)
            {
                hitbufferList.Add(hitBuffer[i]);
            }
            for(int i = 0; i< hitbufferList.Count; i++)
            {
                Vector2 currentNorma = hitbufferList[i].normal;
                if(currentNorma.y > minGroundNormalY)
                {
                    grounded = true;
                    if(yMovement)
                    {
                        groundNormal = currentNorma;
                        currentNorma.x = 0;
                    }
                }
                float projection = Vector2.Dot(velocity, currentNorma);
                if(projection <0)
                {
                    velocity = velocity - projection * currentNorma;

                }
                float modifierDistance = hitbufferList[i].distance - shellRdaius;
                distance = modifierDistance < distance ? modifierDistance : distance;
                }
            rb2d.position = rb2d.position + move.normalized * distance;
        }
    }
        
}
