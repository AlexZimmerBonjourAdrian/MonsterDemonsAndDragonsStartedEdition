using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;

public class CEIdleEnemy : CEnemyStateBase
{
    
    private CEnemyGeneric Enemy;
    private CEMoveState MOVE_STATE;

    private void Update()
    {
        Debug.Log("Estoy Parado Como un tonto");
        if (Input.GetKeyDown(KeyCode.Q))
        {

            
            this.ToState(Enemy, MOVE_STATE);
        }
    }
    /*
    protected CEnemyGeneric Enemy;
    
    public CEIdleEnemy()
    {
    }
   void CStateEnemy.Indle()
    {
        Debug.Log("Entra en el estado de Idle");
        ///Logica Implementada en este estado

    }

    void CStateEnemy.Move()
    {
       // throw new System.NotImplementedException();
        Debug.Log("Me estoy moviedo");
    }

    void CStateEnemy.Attack()
    {
        //throw new System.NotImplementedException();
        Debug.Log("Estoy Atacando");
    }

    void CStateEnemy.Hit()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.Die()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.Follow()
    {
        throw new System.NotImplementedException();

        Debug.Log("Este es el Follow");
    }

    void CStateEnemy.Patrulage()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.DistanceAttack()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.AimCharacter()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.Shoot()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.PreStateShoot()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.Descansando()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.StateInactive()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.Recover()
    {
        throw new System.NotImplementedException();
    }

    void CStateEnemy.AnimDetail()
    {
        throw new System.NotImplementedException();
    }

    public void setEnemy(CEnemyGeneric Enemy)
    {
        throw new System.NotImplementedException();
    }
    */
   
}
