using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CPistolM1911 : CGenericWeapon
{
    // Start is called before the first frame update


    public CPistolM1911()
    {
        Name = "Loop";
        Num = 1;
        
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
