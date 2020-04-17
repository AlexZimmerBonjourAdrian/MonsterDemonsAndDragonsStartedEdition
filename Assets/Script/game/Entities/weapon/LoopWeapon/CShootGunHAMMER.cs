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
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
