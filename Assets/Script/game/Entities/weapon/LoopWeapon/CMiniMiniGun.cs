using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CMiniMiniGun : CGenericWeapon
{


    //string Name = new CGenericWeapon.Name;

    //Se assigna el valor mediante el contructor
    /*
    public CMiniMiniGun()
    {

        Name = "Loop";
        Num = 3;
    }
    */
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
