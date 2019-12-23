using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemy : MonoBehaviour 
{
    public const int maxHealth = 100;
    int currentHealth;
    //public Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
   

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //animator.SetTrigger("Hurt");
        if(currentHealth == 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemigo Muerto");
        //animator.SetBool("IsDead",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        
        
    }
}
