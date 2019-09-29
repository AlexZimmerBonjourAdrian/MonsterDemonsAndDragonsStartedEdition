using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
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
