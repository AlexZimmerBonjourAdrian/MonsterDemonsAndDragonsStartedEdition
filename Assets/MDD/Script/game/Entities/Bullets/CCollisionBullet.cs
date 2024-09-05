using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCollisionBullet : MonoBehaviour
{
    [SerializeField] protected LayerMask _WhatIsCheck;
    protected static int ACTIONSTATE_NONE = 0;
    protected static int ACTIONSTATE_HOVE = 1;
    protected static int ACTIONSTATE_INTERACT = 2;
    [SerializeField] protected float WEIDTH_BOX = 0.2f;
    [SerializeField] protected float HEIGTH_BOX = 0.2f;
    protected int _actionState;
    [SerializeField] protected float Damaged = 10f;
    protected GameObject anyObject;
    protected Component _actionObj;
    protected float TTL;
    // Start is called before the first frame update
    public  void Update()
    {

        if (_actionState == ACTIONSTATE_NONE)
        {
            GameObject obj = CollisionObject();
            if (obj == null)
            {
                return;
            }
            Component actionObj = obj.GetComponent(typeof(ICollision));
            if (actionObj != null)
            {
                _actionObj = actionObj;
                _actionState = ACTIONSTATE_HOVE;
            }
        }
        else if (_actionState == ACTIONSTATE_HOVE)
        {
            GameObject obj = CollisionObject();
            if (obj == null)
            {
                _actionObj = null;
                _actionState = ACTIONSTATE_NONE;
                return;
            }
            Component actionObj = obj.GetComponent(typeof(ICollision));
            if (actionObj == null)
            {
                _actionObj = null;
                _actionState = ACTIONSTATE_NONE;
            }
            else if (actionObj != _actionObj)
            {
                _actionObj = actionObj;
            }

            _actionState = ACTIONSTATE_INTERACT;
        }
        else if (_actionState == ACTIONSTATE_INTERACT)
        {
            (_actionObj as ICollision).OnCollision();
            _actionState = ACTIONSTATE_NONE;
            _actionObj = null;
        }

    }

    public  GameObject CollisionObject()
    {
        Vector2 size = new Vector2(WEIDTH_BOX, HEIGTH_BOX);
        Collider2D[] collisions = Physics2D.OverlapBoxAll(transform.position, size, 0);
        for (int i = 0; i < collisions.Length; i++)
        {
            if (collisions[i].gameObject != gameObject)
            {
                anyObject = collisions[i].gameObject;
                return anyObject.gameObject;
            }
        }
        return anyObject;
    }

}
