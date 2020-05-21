using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyGeneric : MonoBehaviour, ICollision
{

    // private CStateEnemy estado;
    public IEnemyState state;
    public IEnemyState State
    {
        get
        {
            return this.state;
        }
        set
        {
            this.state = value;
        }
    }

    
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
    
    //private CState currentState;
    
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
       // SetState(new CEIdleState(this));
        
        
    }
    // protected float 
    public virtual void OnCollision()
    {
        List<CGenericBullet> var = CBulletManager.Inst.GetList();
        for(int i = var.Count-1;  i <= 0; i--)
        {
            // var[i].get
            setLife(var[i].getDamage() - getLife());
            
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
    public virtual void Update()
    {
        CheckLife();
       // this.State.Update(this);
        //currentState.Tick();
    }
    protected virtual void CheckLife()
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
        /*
        else
        {
            Destroy(gameObject);
        }
        */


    }
    /*
    public void setState(CStateEnemy state)
    {
        this.estado = state;
        this.estado.setEnemy(this);
    }
    */
    /*
    public  void SetState(CState state)
    {
        if(currentState != null)
        {
            currentState.OnStateExit();
        }

        currentState = state;
        gameObject.name = "Enemy - " + state.GetType().Name;

        if(currentState != null)
        {
            currentState.OnStateEnter();
        }
    }

    public void MoveForward(Vector3 destination)
    {
        var derection = GetDirection(destination);
        transform.Translate(derection * Time.deltaTime * SpeedMovement);
    }

    private Vector3 GetDirection(Vector3 destination)
    {
        return (destination - transform.position).normalized;
    }

    */
    /*
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {

        }
    }
    *
    *
    */
   
    
}
