using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRifleGarad : CGenericWeapon
{
   
    public CRifleGarad()
    {
        Name = "Loop";
        Num = 2;
    }
    public override void Start()
    {
        base.Start();
    }
    public override string GetName()
    {
        return Name;
    }
    public override int getNum()
    {
        return Num;
    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
