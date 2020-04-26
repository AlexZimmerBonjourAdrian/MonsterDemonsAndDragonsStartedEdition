using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CEnemy : CEnemyGeneric
{
    public const int maxHealth = 100;

    //public const int STAND_STATE = 0;
    #region STANDARD STATE TO PLAYER
    public const int STATE_NOT_CAST_PLAYER = 0;
    public const int STATE_CAST_PLAYER = 1;
    public const int STATE_HIT = 2;
    public const int STATE_DIYNG= 3;
    #endregion
    
    public int currentHealth;
    //public Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

   
    // Update is called once per frame
    public abstract void setState(int aState);

    public abstract void Move();

    public abstract void CurrentMax();

    public abstract void TakeDamage(int damage);
    /*
    {
        currentHealth -= damage;
        //animator.SetTrigger("Hurt");
        if(currentHealth == 0)
        {
            Die();
        }
    }
    */
    public abstract void Die();
    /*
    {
        Debug.Log("Enemigo Muerto");
        //animator.SetBool("IsDead",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        
        
    }
    */
    
  
   

    
}
