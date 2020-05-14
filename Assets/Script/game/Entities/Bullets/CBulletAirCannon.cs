using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBulletAirCannon :CGenericBullet
{
    // Start is called before the first frame update
    
   public CBulletAirCannon()
    {

    }

    protected override void Start()
    {
        base.Start();
    }

    public override void AddVel(Vector3 vel)
    {
        base.AddVel(vel);
    }
    public override float getDamage()
    {
        return base.getDamage();
    }

    public override void setDamage(float Damage)
    {
        base.setDamage(Damage);
    }
    // Update is called once per frame
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);

    }
}
