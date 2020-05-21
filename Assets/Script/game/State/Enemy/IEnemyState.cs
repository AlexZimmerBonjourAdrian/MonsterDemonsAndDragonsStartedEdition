using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState 
{
    void OnEnter(CEnemyGeneric Enemy);

    void OnExit(CEnemyGeneric Enemy);

    void ToState(CEnemyGeneric Enemy, IEnemyState targetState);

    void Update(CEnemyGeneric Enemy);

    void HandleInput(CEnemyGeneric Enemy);
}
