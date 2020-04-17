using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFlameShoot : CGenericWeapon
{
   public CFlameShoot()
    {
        Name = "Natalia";
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
