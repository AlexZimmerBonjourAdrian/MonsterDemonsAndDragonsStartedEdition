using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public  abstract class CState 
{
    // Start is called before the first frame update
    protected CEnemyGeneric Enemy;
    
    public abstract void Tick();

    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }

    

    public CState(CEnemyGeneric Enemy)
    {
        this.Enemy = Enemy;
    }
}
