using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEMoveState : CEnemyStateBase
{
    // Start is called before the first frame update
    [SerializeField] private CEnemyGeneric Enemy;
    public CEIdleEnemy IDLE_STATE;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Move State");
            if (Input.GetKeyDown(KeyCode.Q))
            {

                Debug.Log("Estoy Parado Como un tonto");
                this.ToState(Enemy, IDLE_STATE);
            }
        
    }
}
