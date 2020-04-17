using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSmallSMG : CGenericWeapon
{
    // Start is called before the first frame update
  public CSmallSMG()
    {
        Name = "Natalia";
        Num = 2;
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
