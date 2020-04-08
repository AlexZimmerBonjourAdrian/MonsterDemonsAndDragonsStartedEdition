using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CGenericBullet :MonoBehaviour
{
    //private Rigidbody2D _rigidbody;

    private void Awake()
    {
       // _rigidbody = GetComponent<Rigidbody2D>();
    }

    public abstract void AddVel(Vector3 vel);
   
}
