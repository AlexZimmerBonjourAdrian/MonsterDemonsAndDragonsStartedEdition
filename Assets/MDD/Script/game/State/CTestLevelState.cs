﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CTestLevelState : MonoBehaviour
{
    [SerializeField]
    private Transform _GenericSpawnCharacter;


    private Transform _GenericSpawnEnemy;
    // Start is called before the first frame update
    [SerializeField] List<Transform> _SpawnEnemy;

    
    private void Update()
    {
        Vector2 pos= new Vector2(_GenericSpawnCharacter.position.x, _GenericSpawnCharacter.position.y);
        /*
        if(Input.GetKeyDown(KeyCode.C))
        {
            CCHaracterManager.Inst.Spawn(pos);
        }
        */

    }

    private void SpawnEnemy()
    {

    }
    private void SpawnWeapond()
    {
        
    }
    private void SwpawnItems()
    {

    }

    
    // Update is called once per frame



}