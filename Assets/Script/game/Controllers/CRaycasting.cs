using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRaycasting : MonoBehaviour
{

    //Todo:(USAR ESTA CLASE PARA HACER ALGUNA ARMA QUE SE DESE).
    public static int ACTIONSTATE_NONE = 0;
    public static int ACTIONSTATE_HOVER = 1;
    public static int ACTIONSTATE_INSTERACT = 2;

    private int _actionstate;
    public float _rayDist = 3f;

    // Start is called before the first frame update
    void Start()
    {
        /*
        if(_actionstate == ACTIONSTATE_NONE)
        {
            GameObject obj;
            if (obj == null)
                return;
        }
        
    }
    
    */
    }

        // Update is called once per frame
        void Update()
        {
        
        GameObject obj = CastRay();
        /*
        if(obj==null)
         {
            return;
         }
         */
        
        }
        

        private GameObject CastRay()

        {
            Vector2 origen = new Vector2(transform.position.x, transform.position.y);
            Vector2 dir = Vector2.right;
            if (gameObject.transform.localScale.x >= 3)
            {
                dir = Vector2.right;


            }
            if (gameObject.transform.localScale.x <= 3)
            {
                dir = Vector2.right * -1;


            }

            Ray2D ray = new Ray2D(origen, dir);
            RaycastHit2D hitinfo = Physics2D.Raycast(origen, dir);
            Physics2D.Raycast(ray.origin, ray.direction * _rayDist);

            if (hitinfo.collider != null)
            {
                Debug.DrawRay(origen, dir * _rayDist, Color.green);
                return hitinfo.collider.gameObject;
            }
            else
            {
                Debug.DrawRay(origen, dir * _rayDist, Color.red);
                return null;
            }
        }

    }
    

