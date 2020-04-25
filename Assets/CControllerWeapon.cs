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
    public List<CGenericWeapon> _ListWeapond = new List<CGenericWeapon>();
    //public List<CGenericWeapon> _ListWeapondLoop = new List<CGenericWeapon>();
    // public List<CGenericWeapon> _ListWeapondNatalia = new List<CGenericWeapon>();
    public List<CGenericWeapon> _ListPlayGolder = new List<CGenericWeapon>();
    //ublic CManagerWeapond _WeapondManager;

    public List<GameObject> _BulletAssets = new List<GameObject>();

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

        for (int i = _ListPlayGolder.Count - 1; i >= 0; i--)
        {
            if (_ListPlayGolder[i] == null)
                _ListPlayGolder.RemoveAt(i);
        }
        //Todo:Revisar Si esto Funciona si no Ponerle un Contador


        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (_ListWeapond != null)
            {
                SelectWeapond(_ListWeapond);
            }
        }
    }
    public void addListWeapond(CGenericWeapon _object)
    {
        Debug.Log("Tomo una arma Armas");
        // _ListWeapond.Add(_object);
        CGenericWeapon Ref = _object;
        // _ListPlayGolder.Add(Ref);
        CGenericWeapon _weapond;
        _ListPlayGolder.Add(Ref);


        for (int i = 0; i <= _ListPlayGolder.Count - 1; i++)
        {

            Debug.Log(_ListPlayGolder[i].getNum());
            switch (_ListPlayGolder[i].getNum())
            {
                case 1:
                    _weapond = Ref.GetComponent<CPistolM1911>();
                    _ListWeapond.Add(_weapond);
                    // PrintArrayArmas();
                    break;
                case 2:
                    _weapond = Ref.GetComponent<CRifleGarad>();
                    break;
                case 3:
                    _weapond = Ref.GetComponent<CMiniMiniGun>();
                    Debug.Log("Tengo La Minigun");
                    _ListWeapond.Add(_weapond);
                    //PrintArrayArmas();
                    break;
                case 4:
                    _weapond = Ref.GetComponent<CPistolAcid>();
                    _ListWeapond.Add(_weapond);
                    break;
                case 5:
                    _weapond = Ref.GetComponent<CShootGunHAMMER>();
                    _ListWeapond.Add(_weapond);
                    break;
                case 6:
                    _weapond = Ref.GetComponent<CAirCannon>();
                    _ListWeapond.Add(_weapond);
                    break;
                case 7:
                    _weapond = Ref.GetComponent<CSniperLaser>();
                    _ListWeapond.Add(_weapond);
                    break;
                case 8:
                    _weapond = Ref.GetComponent<CFlameShoot>();
                    _ListWeapond.Add(_weapond);
                    break;
                /*
                 case 9:
                     _weapond = Ref.GetComponent<CSmallSMG>();
                     _ListWeapond.Add(_weapond);
                     */
                default:
                    Debug.Log("Esta arma no existe");
                    break;
            }
            _ListPlayGolder.Clear();
            RemoveRepetido(_ListWeapond);
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
    
    //CManagerWeapond.Inst._WeapondList


    private void PrintArrayArmas()
    {
        for (int i = _ListPlayGolder.Count - 1; i <= 0; i--)
        {
            Debug.Log(_ListPlayGolder[i].name);
        }
    }
    private void RemoveRepetido(List<CGenericWeapon> weapond)
    {

        for (int i = 0; i >= weapond.Count - 1; i++)
        {
            for (int j = i + 1; j >= weapond.Count - 1; j++)
            {
                if (weapond[j] != null)
                {
                    if (weapond[i].getNum() == weapond[j].getNum())
                    {
                        weapond.RemoveAt(j);

                    }
                    weapond.Sort();
                }

            }
        }
    }
    private CGenericWeapon SelectWeapond(List<CGenericWeapon> weapon, int Count = 0)
    {

        
            Count = Count + 1;
            return weapon[Count];

        
        


    }
    //Todo:que cada Arma Posea una instancia de objeto de la bala a utilizar usando este sistema
    //Solo para prototypo
    /*
    private void SelectBullet(CGenericWeapon Weapond)
    {
      
    }
    */

}
