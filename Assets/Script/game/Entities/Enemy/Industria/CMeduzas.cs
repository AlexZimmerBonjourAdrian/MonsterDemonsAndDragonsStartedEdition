using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMeduzas : CEnemyGeneric
{
    /*
    protected CEnemyData EnemyData;

    private new string name;

    private string descripcion;
    public float Health;
    public float SpeedMovement;
    
    public float Damage;
    public float invulnerabilitytime;
    public float DamageMelee;
    public float DelayChangeState;
    //Esto es para saber si ataca a distancia, esta variable si es true si usara los ataques a distancia 
    public bool IsDistance;
    // Start is called before the first frame update
   */
    protected override void Start()
    {
        base.Start();
    }

    //Todo:Esto es para usar en el prototypo pero aun asi se debe tener cuidado, ver si es util




    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void OnCollision()
    {
        base.OnCollision();
    }

    public override float getLife()
    {
        return base.getLife();
    }

    public override void setLife(float life)
    {
        base.setLife(life);
    }

    protected override void CheckLife()
    {
        base.CheckLife();

    }
    public override void setDamage(float damage)
    {
        base.setDamage(damage);
    }
    public override float getDamage()
    {
        return base.getDamage();
    }

}
