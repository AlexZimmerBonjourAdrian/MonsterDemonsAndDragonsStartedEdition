using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHandSmg : CGenericWeapon
{
    // Start is called before the first frame update
   public CHandSmg()
    {
        Name = "Natalia";
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
