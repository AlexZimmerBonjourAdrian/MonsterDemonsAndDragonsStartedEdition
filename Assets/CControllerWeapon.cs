using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;
using System.Xml;

public class CControllerWeapon : MonoBehaviour
{

    //public List<GameObject> _PlayerLoop;
   // public List<GameObject> _PlayerNatalia;
    //public CGenericWeapon _GenericWeapond;
 //   public List<CGenericWeapon> _PlayerWeapondList = CManagerWeapond.Inst._WeapondList;
    public List<CGenericWeapon> _ListWeapond= new List<CGenericWeapon>();
    //public List<CGenericWeapon> _ListWeapondLoop = new List<CGenericWeapon>();
   // public List<CGenericWeapon> _ListWeapondNatalia = new List<CGenericWeapon>();
    public List<CGenericWeapon> _ListPlayGolder = new List<CGenericWeapon>();
    //ublic CManagerWeapond _WeapondManager;
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

    private void Update()
    {
        /*
        for(int i = _ListPlayGolder.Count - 1; i >= 0; i--) 
        {
            if (_ListPlayGolder[i] == null)
                _ListPlayGolder.RemoveAt(i);
        }
        */
    }
    public void addListWeapond(CGenericWeapon _object)
    {
        Debug.Log("Tomo una arma Armas");
        // _ListWeapond.Add(_object);
        CGenericWeapon Ref = _object;
       // _ListPlayGolder.Add(Ref);
        CGenericWeapon _weapond;
        _ListPlayGolder.Add(Ref);


        for (int i =0; i <= _ListPlayGolder.Count-1; i++)
        {
            Debug.Log(_ListPlayGolder[i].getNum());
            switch (_ListPlayGolder[i].getNum())
            {
                
                case 1:
                    _weapond= Ref.GetComponent<CMiniMiniGun>();
                    Debug.Log("Tengo La Minigun");
                    //PrintArrayArmas();
                    break;
                case 2:
                    _weapond = Ref.GetComponent<CPistolM1911>();
                   // PrintArrayArmas();
                    break;
                default:
                    Debug.Log("Esta arma no existe");
                    break;
            }

        }

            #region PrototypeLogic
            //PlayHolder lOGIC
            /*
            for(int i=_PlayerWeapondList.Count - 1; i <=0;i--)
            {
             if(_PlayerWeapondList[i].GetName() == "Loop")
             {
                    switch (_PlayerWeapondList[i].getNum())
                    {
                        case 1:

                        break;
                    }

             }
            }*/
            /*

            for (int i = _ListWeapond.Count - 1; i <= 0; i--)
            {
                _ListPlayGolder.Add(_ListWeapond[i]);



                Debug.Log(_ListPlayGolder[i].name);
             //   RemoveAndOrdenate(_ListWeapond);
            }
            */

            /*

            for(int i = _ListWeapond.Count-1; i<=0;i--)
            {

                if(_ListWeapond[i].GetName() == "Loop")
                {
                       for(i=_ListWeapondLoop.Count-1; i < 0; i--)
                    {
                        _ListWeapondLoop.Add(_ListWeapond[i]);
                    }
                    RemoveAndOrdenate(_ListWeapondLoop);
                }
                else if(_ListWeapond[i].GetName() == "Natalia")
                {
                    for(i = _ListWeapondNatalia.Count - 1; i < 0; i--)
                    {
                        _ListWeapondNatalia.Add(_ListWeapond[i]);
                    }
                    RemoveAndOrdenate(_ListWeapondNatalia);

                }
                _ListWeapond.Clear();
                */

            #endregion

        }
    /*
    private void RemoveAndOrdenate(List<CGenericWeapon> _wep)
    {
        for (int i = 0; i <= _wep.Count - 1; i++)
        {
            for (int j = i + 1; i <= _wep.Count - 1; j++)
            {
                if (_wep[i].getNum() == _wep[j].getNum())
                {
                    _wep.RemoveAt(j);

                }
                _wep.Sort();
            }
        }


    }
    */
    //CManagerWeapond.Inst._WeapondList


    private void PrintArrayArmas()
    {
        for(int i = _ListPlayGolder.Count -1;i<=0;i--)
        {
            Debug.Log(_ListPlayGolder[i].name);
        }
    }



}
