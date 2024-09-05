using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBistefCarrot : CGenericItem
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }

}
