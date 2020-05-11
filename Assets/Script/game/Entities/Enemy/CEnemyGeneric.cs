using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyGeneric : MonoBehaviour, ICollision
{
    // Start is called before the first frame update
    [SerializeField]
    protected CEnemyData Enemy;
     protected new string name;
    protected string descripcion;
    protected float Health;
    protected float SpeedMovement;
    protected float Damage;
    protected float invulnerabilitytime;
    protected float DamageMelee;
    protected float DelayChangeState;
    protected bool IsDistance;

    protected virtual void Start()
    {
        name = Enemy.name;
        descripcion = Enemy.descripcion;
        Health = Enemy.Health;
        SpeedMovement = Enemy.SpeedMovement;
        Damage = Enemy.Damage;
        invulnerabilitytime = Enemy.invulnerabilitytime;
        DamageMelee = Enemy.DamageMelee;
        DelayChangeState = Enemy.DelayChangeState;
        IsDistance = Enemy.IsDistance;
    }
    // protected float 
    public void OnCollision()
    {
        List<CGenericBullet> var = CBulletManager.Inst.GetList();
        for(int i = var.Count-1;  i <= 0; i--)
        {
            // var[i].get
            var[i].getDamage();
        }

       
        
    }
    //Hay que ver que hacer con el tema de raycasting
    //Todo esto Lo voy a dejar pronto

    public virtual void setLife(float life)
    {
        this.Health = life;
    }

    public virtual float getLife()
    {
        return this.Health;
    }

    public virtual void setDamage(float damage)
    {
        this.Damage = damage;
    }
    public virtual float getDamage()
    {
        return this.Damage;
    }
    public void Update()
    {
        CheckLife();
    }
    private void CheckLife()
    {
        if (getLife() >= 100f)
        {
            Debug.Log("La vida es normal");
        }
        if (getLife() <= 60f && getLife() > 30)
        {
            Debug.Log("Esta medio tocado");
        }
        else if (getLife() <= 30)
        {
            Debug.Log("La vida es muy baja");
        }
        else
        {
            Destroy(gameObject);
        }


    }
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {

        }
    }
    */
    
}
