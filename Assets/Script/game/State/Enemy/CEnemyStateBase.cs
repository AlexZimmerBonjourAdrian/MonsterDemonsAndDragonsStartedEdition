using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CEnemyStateBase : IEnemyState
{
    public virtual void OnEnter(CEnemyGeneric Enemy) { }
    public virtual void OnExit(CEnemyGeneric Enemy) { }
    public virtual void ToState(CEnemyGeneric Enemy, IEnemyState targetState) 
    {
        Enemy.State.OnExit(Enemy);
        Enemy.State = targetState;
        Enemy.State.OnEnter(Enemy);
    }
    public virtual void Update(CEnemyGeneric Character) { }

    public void HandleInput(CEnemyGeneric Enemy) { }


}
