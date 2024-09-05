using System;
using UnityEngine;


public  abstract class CGenericWeapon : MonoBehaviour
{
    protected CWeaponData WeaponData;
    protected string nameWeapon;
    [TextArea(10, 10)]
    protected string descripcion;
    protected float Damage;
    protected float fireRate;
    protected float speedMovement;
    protected float dispercion;
    protected bool isRayCasting = false;
    //[DrawIf("SomeFloat")]
    protected float distance;
    protected float timeReload;
    
    
    public virtual void Start()
    {
        nameWeapon = WeaponData.name;
        descripcion = WeaponData.descripcion;
        Damage = WeaponData.Damage;
        fireRate = WeaponData.fireRate;
        speedMovement = WeaponData.speedMovement;
        dispercion = WeaponData.dispercion;
        isRayCasting = WeaponData.isRayCasting;
        distance = WeaponData.distance;
        timeReload = WeaponData.timeReload;
    }
    protected string Name;


    /*
    public string _name
    {
        get { return name; }
        set
        { _name = value; }
    }
    */
    protected int Num;
    /*
    public int _Num
    {
        get { return Num; }
        set { Num = value; }
    }
        */

    //private Rigidbody2D _rigidbody;

    public virtual string GetName()
    {
        return name;
    }


    public virtual int getNum()
    {
        return Num;
    }
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CControllerWeapon.Inst.addListWeapond(this);
            Destroy(gameObject);
        }
    }

}
