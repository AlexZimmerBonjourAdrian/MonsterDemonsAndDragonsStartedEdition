using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPistolAcid : CGenericWeapon
{
    // Start is called before the first frame update
   public CPistolAcid()
    {
        Name = "Loop";
        Num = 4;

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
