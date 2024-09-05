using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollision : MonoBehaviour
{
    public static int ACTIONSTATE_NONE = 0;
    public static int ACTIONSTATE_HOVE = 1;
    public static int ACTIONSTATE_INTERACT = 2;
    private int _actionState;
    [SerializeField] private  float WEIDTH_BOX = 12f;
    [SerializeField] private float HEIGTH_BOX = 14f;
    GameObject anyObject;
    private Component _actionObj;
    // Start is called before the first frame update
    void Start()
    {
        // Bloquea el cursor
        //Cursor.lockState = CursorLockMode.Locked;
        //Me vuelve invisible el cursor
        // Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: revisar la clase CRaycasting - Terminar el sistema de interacion con los objetos
        //TODO:Crear Objetos de Interacion lo que sea cajas, arboles, personajes, etc
        //TODO:Crear otras interfaces para otras cosas, 
        //lo que hace es lo siguiente usa una caja de colisiones e almacena en una lista de lo objetos almacenados
        //lo que hace es recorrer y chequear si los objetos que estan van a interactuar con el
        //Crear una maquina de estado para comprobar los estados si no hay interacion, si hay interacion pero no interacion por usuario y si el usuario interactua
        //se podria optimizar ya que pero es mejor que el sistema de unity
        //

        
        if(_actionState == ACTIONSTATE_NONE)
        {
            GameObject obj = CollisionObject();
            if (obj == null)
                return;

            Component actionObj = obj.GetComponent(typeof(Iinteractive));
            if(actionObj != null)
            {
                _actionObj = actionObj;
                _actionState = ACTIONSTATE_HOVE;
            }
        }
        else if(_actionState == ACTIONSTATE_HOVE)
        {
            GameObject obj = CollisionObject();
            if(obj == null)
            {
                _actionObj = null;
                _actionState = ACTIONSTATE_NONE;
                return;
            }

            Component actionObj = obj.GetComponent(typeof(Iinteractive));
            if(actionObj == null)
            {
                _actionObj = null;
                _actionState = ACTIONSTATE_NONE;
            }
            else if(actionObj != _actionObj)
            {
                _actionObj = actionObj;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                _actionState = ACTIONSTATE_INTERACT;
                Debug.Log("Entra en el entract");
                Debug.Log(_actionObj.name);
            }
        }
        else if(_actionState == ACTIONSTATE_INTERACT)
        {
            (_actionObj as Iinteractive).OnInteractive();
            _actionState = ACTIONSTATE_NONE;
            _actionObj = null;
        }
        
        /*
        if (_actionState == ACTIONSTATE_NONE)
        {
            GameObject obj = anyObject;
            if (obj == null)
            {
                return;
                Component actionObj = obj.GetComponent(typeof(Iinteractive));
                if (actionObj == null)
                {
                    _actionObj = null;
                    _actionState = ACTIONSTATE_NONE;
                }
                else if (actionObj != _actionObj)
                {
                    _actionObj = actionObj;
                }
                if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0))
                    _actionState = ACTIONSTATE_INTERACT;

            }
            else if (_actionState == ACTIONSTATE_INTERACT)
            {
                (_actionObj as Iinteractive).OnInteractive();
                _actionState = ACTIONSTATE_NONE;
                _actionObj = null;
            }

        }


    */

    }

    private GameObject CollisionObject()
    {
        Vector2 size = new Vector2(WEIDTH_BOX, HEIGTH_BOX);
        Collider2D[] collisions = Physics2D.OverlapBoxAll(transform.position, size,0f);
        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject)
            {
                anyObject = collisions[i].gameObject;
                //Debug.Log("Estoy Chocando");
               // Debug.Log(anyObject.gameObject.name);
                return anyObject.gameObject;
               
               
            }
            
        }
        return anyObject;
    }
    private void OnDrawGizmos()
    {
        Vector3 size = new Vector3(WEIDTH_BOX, HEIGTH_BOX,0f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(gameObject.transform.position, size);
    }
}
    

