using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM1GaratBullet :CGenericBullet
{
    // Start is called before the first frame update

    float _damage;
    float _TimeToDie;
    float _GravityFoce;
    //Vector2 _velMove;
    private void Awake()
    {
        
    }
    private void Start()
    {

        
    }

    public void Update()
    {
       
    }
    public override void setTimeToLife(float Tlife)
    {
        base.setTimeToLife(Tlife);
        _TimeToDie = Tlife;

    }
    public override void setGravity(float gravity)
    {
        base.setGravity(gravity);
        _GravityFoce = gravity;
    }
    public override void setDamage(float Damage)
    {
        base.setDamage(Damage);
        _damage = Damage;
       
       
        
    }
    /*
    public override void setVel(Vector2 vel)
    {
        base.setVel(vel);
        _velMove = vel;
    }
    */

    public float getDamage()
    {
        return _damage;
    }
    
    public float getGravity()
    {
        return _GravityFoce;
    }
    public float getTimeIsLife()
    {
        return _TimeToDie;
    }




   
    private void OnCollisionEnter2D(Collision2D collision)
      {
        if(collision.gameObject != gameObject)
        {
            Debug.Log("Ignorame");
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            //Funcion ejecucion de particululas o effectos.
            Debug.Log("Se Dstrullo La Balla");
            DestroyImmediate(this);
        }
        
      }

}