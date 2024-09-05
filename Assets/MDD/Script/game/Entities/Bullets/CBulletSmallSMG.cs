using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBulletSmallSMG : CGenericBullet
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void AddVel(Vector3 vel)
    {
        _rigidbody.AddForce(vel, ForceMode2D.Impulse);
    }
    public override float getDamage()
    {
        return base.getDamage();
    }
    public override void setDamage(float Damage)
    {
        base.setDamage(Damage);
    }
    /*
    public override void setGravity(float gravity)
    {
        base.setGravity(gravity);
    }
    */

    public override void setTimeToLife(float TTLife)
    {
        base.setTimeToLife(TTLife);
    }
    public override float GetTimeToLiFe()
    {
        return base.GetTimeToLiFe();
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);

    }

}
