using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSniperLaser : CGenericWeapon
{
    // Start is called before the first frame update
  public CSniperLaser()
    {
        Name = "Natalia";
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
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
