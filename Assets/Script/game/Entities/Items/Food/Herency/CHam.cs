using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHam :CGenericItem
{
    protected override void Start()
    {
        base.Start();
    }
    // Start is called before the first frame update
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }

}
