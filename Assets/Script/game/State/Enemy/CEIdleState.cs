using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEIdleState : CState
{
    private Vector3 Dir;
    public CEIdleState(CEnemyGeneric Enemy) : base(Enemy)
    {

    }
    public override void Tick()
    {
        
    }
    // Start is called before the first frame update

    public override void OnStateEnter()
    {
        //Se Carga la logica deseada para hacer lo que se nesesite
    }
    /*
    private bool ReachedHome()
    {
       
    }
    */
}
