using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenericBullet :MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public virtual void AddVel(Vector3 vel)
    {
        _rigidbody.AddForce(vel, ForceMode2D.Impulse);
    }
   
}
