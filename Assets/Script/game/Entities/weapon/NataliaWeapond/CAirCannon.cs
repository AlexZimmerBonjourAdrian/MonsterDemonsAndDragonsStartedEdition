using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAirCannon : CGenericWeapon
{
    // Start is called before the first frame update
    private CAirCannon()
    {
        Name = "Natalia";
        Num = 5;
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
