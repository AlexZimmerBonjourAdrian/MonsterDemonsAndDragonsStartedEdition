using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShootGunHAMMER : CGenericWeapon
{
    // Start is called before the first frame update
 
        public CShootGunHAMMER()
        {
        Name = "Loop";
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

    // Update is called once per frame
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
