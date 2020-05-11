using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CTofuFish : CGenericItem
{
    protected override void Start()
    {
        base.Start();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
  
}
