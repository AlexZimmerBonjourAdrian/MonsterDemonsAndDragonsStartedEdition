﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField]enum WeaponSelect
    {
        Pistol,ShootGun,MachineGun,Sniper,RocketLouncher
    };


 
    struct ChangeValuesToBullet
    {
        public float damage;
        public float changeCritial;
        public bool Reload; // optional
        public float Dispersion;
        public bool SecondShoot;// este es tambien opcional//solo integrar cuando se tenga todo el tipo de disparo
         
    }
    [SerializeField]private WeaponSelect WepSel;
    
    
    

    void start ()
    {
        WepSel = WeaponSelect.Pistol;
    }
      
    // Start is called before the first frame update

       WeaponSelect ChangeWeapond (WeaponSelect weap)
    {
        if(weap == WeaponSelect.Pistol)
        {
           ChangeValuesToBullet ValuesWepistol;
            /*
            ValuesWepistol.damage = 20f;
            ValuesWepistol.Dispersion = 2f;
            ValuesWepistol.
            */

        }

        if(weap == WeaponSelect.MachineGun)
        {
        //[SerializeField] private ChangeValuesToBullet ValuesWepMachineGun;
        //ValuesWep 
        }
        return weap;
    }
    
        
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void AddVel(Vector2 vel)
    {
        _rigidbody.AddForce(vel,ForceMode2D.Impulse);
    }

    
    // Update is called once per frame
  
}