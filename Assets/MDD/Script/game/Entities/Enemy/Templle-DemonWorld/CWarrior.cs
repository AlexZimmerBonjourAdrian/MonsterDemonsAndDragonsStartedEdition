using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWarrior : CEnemyGeneric
{
    // Start is called before the first frame update

    private const int STATE_STAND = 0;
    private const int STATE_MOVE = 1;
    private const int STATE_FOLLOW = 2;
    protected override void Start()
    {
        base.Start();

    }


    // Update is called once per frame
   
}
