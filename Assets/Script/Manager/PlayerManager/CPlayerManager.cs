using System;
using UnityEngine;


[Serializable]
public class CPlayerManager 
{
    // Start is called before the first frame update
    public Transform _SpawnPoint;
    public int _PlayerNumber;
    [HideInInspector]
    public GameObject _Instance;
    [HideInInspector]
    public CharacterController2D _movement;
    [HideInInspector]
    public CShootScript _shoot;
    
    
    //private GameObject _CanvasGameObject;
    public void Setup()
    {
        _movement = _Instance.GetComponent<CharacterController2D>();
        _shoot = _Instance.GetComponent<CShootScript>();
        /*
        if (_PlayerNumber == 0)
        {

        }
        else if (_PlayerNumber == 1)
        {

        }
        */
    }
    /*
    public void Reset()
    {
        
    }
    */
}
