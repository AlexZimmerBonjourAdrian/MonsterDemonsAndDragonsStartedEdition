using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CControllerWeapon : MonoBehaviour
{

    public List<GameObject> _PlayerLoop;
    public List<GameObject> _PlayerNatalia;
    public static CControllerWeapon Inst
    {
        get
        {
            if (_inst == null)
            {
                GameObject obj = new GameObject("ControllerWeapon");
                return obj.AddComponent<CControllerWeapon>();
            }
            return _inst;
        }
    }
    private static CControllerWeapon _inst;

    private void Awake()
    {
        if (_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
       // _PlayerLoop = new GameObject[5];
    }

    private void addListWeapond(GameObject _object)
    {
        for(int  i=0; i <= _PlayerLoop.Count-1; i++)
        {
          //  if(_PlayerLoop.)
        }
    }
    
}
