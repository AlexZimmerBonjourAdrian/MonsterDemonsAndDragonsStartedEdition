using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CController2d : MonoBehaviour
{
    public LayerMask collisionMask;
    const float skinwidth = .015f;
    public int horizontalRayCount = 4;
    public int verticalRayCount = 4;

    float maxClimbAngle = 80;
    float maxDecendeAngle = 80;

    float horizontalRaySpacing;
    float verticalRaySpacing;

     BoxCollider2D collider;
   

    RaycastOrigins raycastOrigins;

    public CollisionInfo collisions;
    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        CalculatingRaySpacing();
    }

    /*
    private void Update()
    {
        UpdateRayCastOrigins();
        CalculatingRaySpacing();

        for(int i = 0; i< verticalRayCount; i++)
        {
            Debug.DrawRay(raycastOrigins.bottomLeft + Vector2.right * verticalRaySpacing * i, Vector2.up * -2, Color.red);
        }
    }
    */
    void UpdateRayCastOrigins()
    {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinwidth * -2);

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
        raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.max.y);
        raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y);
    }

    void CalculatingRaySpacing()
    {

        Bounds bounds = collider.bounds;
        bounds.Expand(skinwidth * -2);

        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
        verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

        horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);
        verticalRaySpacing = bounds.size.x / (verticalRayCount - 1);

    }



    struct RaycastOrigins
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }
    public void Move(Vector3 velocity)
    {
        UpdateRayCastOrigins();
        collisions.Reset();
        collisions.velocityOld = velocity;
        if(velocity.y < 0)
        {
            DescendSope(ref velocity);
        }

        if (velocity.x != 0)
        {
            HorizontalCollisions(ref velocity);
        }
        if (velocity.y != 0)
        {
            VerticalCollisions(ref velocity);
        }

        transform.Translate(velocity);
    }
    void VerticalCollisions(ref Vector3 velocity)
    {
        float directionY = Mathf.Sign(velocity.y);
        float rayLength = Mathf.Abs(velocity.y) + skinwidth;
        for (int i = 0; i < verticalRayCount; i++)
        {
            Vector2 rayOrigin = (directionY == -1) ? raycastOrigins.bottomLeft : raycastOrigins.topLeft;
            rayOrigin += Vector2.right * (verticalRaySpacing * i + velocity.x);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, collisionMask);
            // Debug.DrawRay(raycastOrigins.bottomLeft + Vector2.right * verticalRaySpacing * i, Vector2.up * -2, Color.red);
            Debug.DrawRay(rayOrigin, Vector2.up * directionY * rayLength, Color.red);
            if (hit)
            {
                velocity.y = (hit.distance - skinwidth) * directionY;
                rayLength = hit.distance;

                if(collisions.climbingSlope)
                {
                    velocity.x = velocity.y / Mathf.Tan(collisions.slopeAngle * Mathf.Deg2Rad) * Mathf.Sign(velocity.x);
                }

                collisions.below = directionY == -1;
                collisions.above = directionY == 1;
            }
        }
        if(collisions.climbingSlope)
        {
            float directionX = Mathf.Sign(velocity.x);
            rayLength = Mathf.Abs(velocity.x) + skinwidth;
            Vector2 rayOrigin = ((directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight)+ Vector2.up * velocity.y;
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, rayLength, collisionMask);

            if(hit)
            {
                float slopeAngle = Vector2.Angle(hit.normal, Vector2.up);
                if(slopeAngle != collisions.slopeAngle)
                {
                    velocity.x = (hit.distance - skinwidth) * directionX;
                    collisions.slopeAngle = slopeAngle;
                }
            }
        }
    }
    public struct CollisionInfo
      {
        public bool above, below;
        public bool left, right;

        public bool climbingSlope;
        public bool descendingSlope;
        public Vector3 velocityOld;
        public float slopeAngle, slopeAngleOld;
        public void Reset()
        {
            above = below = false;
            left = right = false;
            climbingSlope = false;
            descendingSlope = false;
            slopeAngleOld = slopeAngle;
            slopeAngle = 0;
        }

       }
    void ClimbSlope(ref Vector3 velocity, float slopeAngle)
    {
        float moveDistance = Mathf.Abs(velocity.x);
        float climbVelocityY = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * moveDistance;

        if(velocity.y <= climbVelocityY)
       
            //  velocity.y = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * moveDistance;
            velocity.y = climbVelocityY;
            velocity.x = Mathf.Cos(slopeAngle * Mathf.Deg2Rad) * moveDistance * Mathf.Sign(velocity.x);
        collisions.below = true;
        collisions.climbingSlope = true;
        collisions.slopeAngle = slopeAngle;

        
    }
void HorizontalCollisions(ref Vector3 velocity)
    {
        float directionX = Mathf.Sign(velocity.x);
        float rayLength = Mathf.Abs(velocity.x) + skinwidth;
        for (int i = 0; i < horizontalRayCount; i++)
        {
            Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight;
            rayOrigin += Vector2.up * (horizontalRaySpacing * i + velocity.x);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX, collisionMask);
            //  Debug.DrawRay(raycastOrigins.bottomLeft + Vector2.right * verticalRaySpacing * i, Vector2.up * -2, Color.red);
            Debug.DrawRay(rayOrigin, Vector2.right * directionX * rayLength, Color.red);
            if (hit)
            {
                float slopeAgle = Vector2.Angle(hit.normal, Vector2.up);


                if (i == 0 && slopeAgle <= maxClimbAngle) {
                    if(collisions.descendingSlope)
                    {
                        collisions.descendingSlope = false;
                        velocity = collisions.velocityOld;
                    }
                    float distanceToSlopeStart = 0;
                    if(slopeAgle != collisions.slopeAngleOld)
                    {
                        distanceToSlopeStart = hit.distance - skinwidth;
                        velocity.x -= distanceToSlopeStart * directionX;
                    }
                    ClimbSlope(ref velocity, slopeAgle);
                    velocity.x += distanceToSlopeStart * directionX;
               // print(slopeAgle);
                }
                if(!collisions.climbingSlope || slopeAgle > maxClimbAngle)
                {

               
                velocity.x = (hit.distance - skinwidth) * directionX;
                rayLength = hit.distance;
                if(collisions.climbingSlope)
                 {
                        velocity.y = Mathf.Tan(collisions.slopeAngle * Mathf.Deg2Rad) * Mathf.Abs(velocity.x);
                 }
                collisions.left = directionX == -1;
                collisions.right = directionX == 1;
                }
            }
        }
    }
    void DescendSope(ref Vector3 velocity)
    {
        float directionX = Mathf.Sign(velocity.x);
        Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomRight : raycastOrigins.bottomLeft;
        RaycastHit2D hit= Physics2D.Raycast(rayOrigin, -Vector2.up,Mathf.Infinity,collisionMask);
        
        if(hit)
        {
            float slopeAngle = Vector2.Angle(hit.normal, Vector2.up);
            if(slopeAngle != 0 && slopeAngle <= maxDecendeAngle)
            {
                if(Mathf.Sign(hit.normal.x) == directionX)
                {
                    if (hit.distance - skinwidth <= Mathf.Tan(slopeAngle * Mathf.Deg2Rad) * Mathf.Abs(velocity.x))
                    {
                        float moveDistance = Mathf.Abs(velocity.x);
                        float descendVelocity = Mathf.Sin(slopeAngle * Mathf.Deg2Rad) * moveDistance;
                        velocity.x = Mathf.Cos(slopeAngle * Mathf.Deg2Rad) * moveDistance * Mathf.Sign(velocity.x);
                        velocity.y -= descendVelocity;

                        collisions.slopeAngle = slopeAngle;
                        collisions.descendingSlope = true;
                        collisions.below = true;
                       
                    }
                }
            }
        }
    }
 
}
