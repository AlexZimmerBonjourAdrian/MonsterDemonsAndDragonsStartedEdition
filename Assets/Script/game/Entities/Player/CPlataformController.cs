using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class CPlataformController : CRayController
{
    public LayerMask passangerMask;
    public Vector3 move;
    public override void Start()
    {
        base.Start();
    }
    private void Update()
    {
        UpdateRayCastOrigins();
        Vector3 velocity = move * Time.deltaTime;

        MovePassagers(velocity);
        transform.Translate(velocity);


    }

    void MovePassagers(Vector3 velocity)
    {
        HashSet<Transform> movedPassagers = new HashSet<Transform>();
        float directionX = Mathf.Sign(velocity.x);
        float directionY = Mathf.Sign(velocity.y);

        // Vertically moving plataform   
        if (velocity.y != 0)
        {
            float rayLegnth = Mathf.Abs(velocity.y) + skinwidth;

            for (int i = 0; i < verticalRayCount; i++)
            {
                Vector2 rayOrigin = (directionY == -1) ? raycastOrigins.bottomLeft : raycastOrigins.topLeft;
                rayOrigin += Vector2.right * (verticalRaySpacing * i);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, rayLegnth, passangerMask);

                if (hit)
                {
                    if (!movedPassagers.Contains(hit.transform))
                    {

                        movedPassagers.Add(hit.transform);
                        float pushX = (directionY == 1) ? velocity.x : 0;
                        float pushY = velocity.y - (hit.distance - skinwidth) * directionY;

                        hit.transform.Translate(new Vector3(pushX, pushY));
                    }
                }
            }
        }
        //Horizontally moving plataform
        if (velocity.x != 0)
        {
            float rayLength = Mathf.Abs(velocity.x) + skinwidth;

            for (int i = 0; i < horizontalRayCount; i++)
            {
                Vector2 rayOrigin = (directionX == -1) ? raycastOrigins.bottomLeft : raycastOrigins.bottomRight;
                rayOrigin += Vector2.up * (horizontalRaySpacing * i);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.right * directionX,rayLength, passangerMask);
                //  Debug.DrawRay(raycastOrigins.bottomLeft + Vector2.right * verticalRaySpacing * i, Vector2.up * -2, Color.red);


                if (hit)
                {
                    if (!movedPassagers.Contains(hit.transform))
                    {

                        movedPassagers.Add(hit.transform);
                        float pushX = velocity.x - (hit.distance - skinwidth) * directionX; ;
                        float pushY = 0;

                        hit.transform.Translate(new Vector3(pushX, pushY));
                    }
                }
            }
            //Passeger on top of a horizontally or downward plataform
           
        }
        if (directionY == -1 || velocity.y == 0 && velocity.x != 0)
        {
            float rayLegnth = skinwidth * 2;

            for (int i = 0; i < verticalRayCount; i++)
            {
                Vector2 rayOrigin = raycastOrigins.topLeft + Vector2.right * (verticalRaySpacing * i);
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up, rayLegnth, passangerMask);

                if (hit)
                {
                    if (!movedPassagers.Contains(hit.transform))
                    {

                        movedPassagers.Add(hit.transform);
                        float pushX = velocity.x;
                        float pushY = velocity.y;

                        hit.transform.Translate(new Vector3(pushX, pushY));
                    }
                }
            }
        }

    }
}
