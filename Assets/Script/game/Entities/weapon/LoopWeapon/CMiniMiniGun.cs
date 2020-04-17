using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CMiniMiniGun : CGenericWeapon
{


    //string Name = new CGenericWeapon.Name;

    //Se assigna el valor mediante el contructor
    public CMiniMiniGun()
    {
        Name = "Loop";
        Num = 3;
    }

    public override string GetName()
    {
        return Name;
    }
    public override int getNum()
    {
        return Num;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            CControllerWeapon.Inst.addListWeapond(this);
            Destroy(gameObject);
        }
    }
}
