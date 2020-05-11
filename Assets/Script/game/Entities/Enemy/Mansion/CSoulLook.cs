using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSoulLook : CEnemyGeneric, Iinteractive
{
    private CPlayer Player;
    public void OnInteractive()
    {
        
    }
    protected override void Start()
    {
        base.Start();

    }
    // Start is called before the first frame update
    /*
    void start()
    {
        Player = GetComponent<CPlayer>();
        currentHealth = maxHealth;
    }
    public override void Die()
    {
        Debug.Log("Enemigo Muerto");
        //animator.SetBool("IsDead",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
    public override void CurrentMax()
    {
        throw new System.NotImplementedException();
    }

  
    public override void setState(int aState)
    {
        throw new System.NotImplementedException();
    }

    public override void TakeDamage(int damage)
    {
        // throw new System.NotImplementedException();
        currentHealth -= damage;
        //animator.SetTrigger("Hurt");
        if (currentHealth == 0)
        {
            Die();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Move()
    {
        
    }
    */
}
