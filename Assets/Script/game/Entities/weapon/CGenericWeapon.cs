using System;
using UnityEngine;


public  abstract class CGenericWeapon : MonoBehaviour
{
   public string Name;

    /*
    public string _name
    {
        get { return name; }
        set
        { _name = value; }
    }
    */
    public int Num;
    /*
    public int _Num
    {
        get { return Num; }
        set { Num = value; }
    }
        */

    //private Rigidbody2D _rigidbody;

    public abstract string GetName();


    public abstract int getNum();
   

}
