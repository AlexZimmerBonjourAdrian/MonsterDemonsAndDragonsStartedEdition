using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBulletManager : MonoBehaviour
{
    private ArrayList _bulletList = new ArrayList();
    [SerializeField]private GameObject _bulletAsset;
  




    //Temp system :: solo para usar en la etapa de prototypo
    private const int GenericBullet_STATE = 0;
    private const int SmgBullet_STATE = 1;
    private const int ShootGunBullet_STATE = 2;
    private const int SniperGunBullet_STATE = 3;
    private const int MiniGunBullet_STATE = 4;
    private const int RifleBullet_STATE = 5;
    private const int RocketLauncher_STATE = 6;
    private const int OtherBullet_STATE = 7;
    [SerializeField]public int state = 0;

    public static CBulletManager Inst
    {
        get
        {
            if(_inst == null)
            {
                GameObject obj = new GameObject("BulletManager");
                return obj.AddComponent<CBulletManager>();
            }
            return _inst;
        }
    }
    private static CBulletManager _inst;
    private void Awake()
    {
        if(_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
        //_bulletAsset = Resources.Load<GameObject>("GenericBullet");
       // _bulletList = new List<CGenericBullet>();
    }

    //private void registerSingleton()
    //{
    //    if(mInst == null)
    //    {
    //        mInst = this;
    //    }
    //    else
    //    {
    //        throw new UnityException("Error: cannot create create BulletManager");
    //    }
    //}

    
    void Update()
    {
        /*
        
        if(state==GenericBullet_STATE)
        {
             _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/GenericBullet.pref");
        //if(_bulletAsset.gameObject == null)
            
               // Debug.Log("Error la Bala es un objeto nullo");
            
        }
        */
       
        for (int i = _bulletList.Count - 1; i >= 0; i--)
        {
            if (_bulletList[i] == null)
                _bulletList.RemoveAt(i);
        }
    }
    public void setState(int aState)
    {
        state = aState;
        if(state == GenericBullet_STATE)
        {

        }

        else if(state == SmgBullet_STATE)
        {

        }
        else if(state ==ShootGunBullet_STATE )
        {

        }
        else if(state == MiniGunBullet_STATE)
        {

        }
        else if(aState == RifleBullet_STATE)
        {

        }
        else if(aState == SniperGunBullet_STATE)
        {

        }
        else if(aState ==RocketLauncher_STATE)
        {

        }
        else if(aState == OtherBullet_STATE)
        {

        }

    }
    public void Spawn(Vector2 pos, Vector2 vel)
    {
        /*
         if (Input.GetKeyDown(KeyCode.X))
        {
            if(state == GenericBullet_STATE)
            {
                GameObject obj = (GameObject)Instantiate(_bulletAsset, _positionShoot.position, Quaternion.identity);
                //CBullet newBullet = obj.GetComponent<CBullet>();
                // newBullet.AddVel(vel);
                // Destroy(obj, 3f);
                //_bulletList.Add(newBullet);
                CBullet newbullet = obj.GetComponent<CGenericBullet>();
                newbullet.setVel(vel);
                _bulletList.Add(newbullet);
            }

        }

        else if (Input.GetKey(KeyCode.X))
            if (state == M1GaractBullet_STATE)
            {
                GameObject obj = (GameObject)Instantiate(_bulletAsset, _positionShoot.position, Quaternion.identity);
                //CBullet newBullet = obj.GetComponent<CBullet>();
                // newBullet.AddVel(vel);
                // Destroy(obj, 3f);
                //_bulletList.Add(newBullet);
                CBullet newbullet = obj.GetComponent<CM1GaratBullet>();
                newbullet.setVel(vel);
                _bulletList.Add(newbullet);
            }
           */

        /*
        GameObject obj = (GameObject)Instantiate(_bulletAsset, pos, Quaternion.identity);
        CGenericBullet newBullet = obj.GetComponent<CGenericBullet>();
        newBullet.AddVel(vel);
        _bulletList.Add(newBullet);
        */
        GameObject obj = (GameObject)Instantiate(_bulletAsset, pos, Quaternion.identity);
        CGenericBullet newBullet = obj.GetComponent<CGenericBullet>();
        newBullet.AddVel(vel);
        _bulletList.Add(newBullet);

    }
}


