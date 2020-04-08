using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShootScript : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController2D _controller;
    [SerializeField] private Transform _positionShoot;
    private float _vel= 40f;
    private float _rote;
    private int _SelectWeapond=1;
    private void Start()
    {
        _controller = GetComponent<CharacterController2D>();
       //_positionShoot.Find("Shoot");
       
    }

    private void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Q))
        {
            
            _SelectWeapond = _SelectWeapond + 1;
            CBulletManager.Inst.setWeapon(_SelectWeapond);
            if(_SelectWeapond > 5)
            {
                _SelectWeapond = 1;
            }
        }
        */


        if(Input.GetKey(KeyCode.X))
        {
           
                CBulletManager.Inst.Spawn(_positionShoot.position, Vector2.right * _vel,_rote);


            
        }
        
    }

    private void ControlFlip()
    {
        if(_controller.getFlip() == true)
        {
            _rote = 1f;
        }
        else
        {
            _rote *= -1f;
        }

    }
 



}
