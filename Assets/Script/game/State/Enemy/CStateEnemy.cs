using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CStateEnemy
{
    #region GenericState
    void Indle();
    void Move();
    void Attack();
    void Hit();
    void Die();

    #endregion

    #region MoreSpecificStates
    void Follow();
  
    void Patrulage();
    #endregion

    #region DistanceState
    void DistanceAttack();

    void AimCharacter();

    void Shoot();

    void PreStateShoot();
    #endregion


    #region DetaileState
    void Descansando();

    void StateInactive();

    void Recover();

    void AnimDetail();
    #endregion

    //public void setEnemy(CEnemyGeneric Enemy);
    
        
  



    // Start is called before the first frame update

}