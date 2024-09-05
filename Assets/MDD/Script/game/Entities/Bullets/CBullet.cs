using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CBullet :MonoBehaviour
{

    /*

    //[SerializeField] private float TTL = .5f;
    private  CBullet()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        WEIDTH_BOX = 0.2f;
        HEIGTH_BOX = 0.2f;
        
    }
    [SerializeField]enum WeaponSelect
    {
        Pistol,ShootGun,MachineGun,Sniper,RocketLouncher
    };
    

    
       struct ChangeValuesToBullet
       {
           public float damage;
           public float changeCritial;
           public bool Reload; // optional
           public float Dispersion;
           public bool SecondShoot;// este es tambien opcional//solo integrar cuando se tenga todo el tipo de disparo

       }
       
    
    [SerializeField]private WeaponSelect WepSel;
    


    
     void start ()
     {

         WepSel = WeaponSelect.Pistol;

     }


     // Start is called before the first frame update


        WeaponSelect ChangeWeapond (WeaponSelect weap)
     {
         if(weap == WeaponSelect.Pistol)
         {
            ChangeValuesToBullet ValuesWepistol;

             ValuesWepistol.damage = 20f;
             ValuesWepistol.Dispersion = 2f;
             ValuesWepistol.


         }

         if(weap == WeaponSelect.MachineGun)
         {
         //[SerializeField] private ChangeValuesToBullet ValuesWepMachineGun;
         //ValuesWep 
         }
         return weap;

     }
  
   void start()
   {

       //_rigidbody = GetComponent<Rigidbody2D>();
   }
 

    public virtual void setVel(Vector2 vel)
    {
        //_rigidbody.AddForce(vel,ForceMode2D.Impulse);
    }

    public virtual void setDamage(float Damage)
    {
        this.Damaged = Damage;
    }

    public virtual void setGravity(float gravity)
    {

    }

    public virtual void setTimeToLife(float TTLife)
    {
        this.TTL = TTLife;
    }
    public float GetTimeToLiFe()
    {
        TTL = TTL * Time.deltaTime;
        return this.TTL;
    }

    public override void AddVel(Vector3 vel)
    {
        base.AddVel(vel);


    }
    
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != gameObject && collision.gameObject.tag !="Player")
        {
            Destroy(gameObject);
        }
    }
  
    //funcion de control de particulas o sprite 
    Collider2D[] colliders = Physics2D.OverlapCircleAll()

    private void OnDrawGizmos()
    {
        
    }
    

    
private void FixedUpdate()
{
    Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f, _WhatIsCheck);
    for (int i = 0; i < colliders.Length; i++)
    {
        if (colliders[i].gameObject != gameObject)
        {
            Destroy(gameObject);
        }

    }
}

    
    private void Update()
    {
        
     if(_actionState == ACTIONSTATE_NONE)
     {
            GameObject obj = CollisionObject();
            if(obj == null)
            {
                return;
            }
            Component actionObj = obj.GetComponent(typeof(ICollision));
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
            Component actionObj = obj.GetComponent(typeof(ICollision));
            if(actionObj== null)
            {
                _actionObj = null;
                _actionState = ACTIONSTATE_NONE;
            }
            else if(actionObj != _actionObj)
            {
                _actionObj = actionObj;
            }

            _actionState = ACTIONSTATE_INTERACT;
        }
     else if(_actionState == ACTIONSTATE_INTERACT)
        {
            (_actionObj as ICollision).OnCollision();
            _actionState = ACTIONSTATE_NONE;
            _actionObj = null;
        }
    
    }
    
    
    private GameObject CollisionObject()
    {
        Vector2 size = new Vector2(WEIDTH_BOX, HEIGTH_BOX);
        Collider2D[] collisions = Physics2D.OverlapBoxAll(transform.position, size, 0);
        for(int i = 0; i < collisions.Length; i++)
        {
            if(collisions[i].gameObject != gameObject)
            {
                anyObject = collisions[i].gameObject;
                return anyObject.gameObject;
            }
        }
        return anyObject;
    }

  
    
    
    
    void  Update()
    {
        base.Update(); 

    }
    
    public virtual void setVel(Vector2 vel)
    {
        //_rigidbody.AddForce(vel,ForceMode2D.Impulse);
    }
   
    public override void setDamage(float Damage)
    {
        base.setDamage(Damage);
    }
    
    
    public virtual void setGravity(float gravity)
    {

    }
    

    public override void setTimeToLife(float TTLife)
    {
        base.setTimeToLife(TTLife);
    }
    public override float GetTimeToLiFe()
    {
        //base.GetTimeToLiFe();
        TTL = TTL * Time.deltaTime;
        return this.TTL;
    }
    
    public override GameObject CollisionObject()
    {
        //base.CollisionObject();
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
    
    private void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f, _WhatIsCheck);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                Destroy(gameObject);
            }

        }
    }

    public override void AddVel(Vector3 vel)
    {
        base.AddVel(vel);
    }
    public  float GetDamage()
    {
        
        return Damaged;
    }
    
    private void OnDrawGizmos()
    {
        Vector3 size = new Vector3(WEIDTH_BOX, HEIGTH_BOX, 0f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(gameObject.transform.position, size);
    }
    */
}
