using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CBulletManager : CGenericBullet
{
    private List<CGenericBullet> _bulletList=new List<CGenericBullet>();
    [SerializeField]private GameObject _bulletAsset;
  
    



    //Temp system :: solo para usar en la etapa de prototypo
    /*
    private const int GenericBullet_STATE = 0;
    private const int SmgBullet_STATE = 1;
    private const int ShootGunBullet_STATE = 2;
    private const int SniperGunBullet_STATE = 3;
    private const int MiniGunBullet_STATE = 4;
    private const int RifleBullet_STATE = 5;
    private const int RocketLauncher_STATE = 6;
    private const int OtherBullet_STATE = 7;
    public int state = 0;
    */
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
    private void Start()
    {
        //_bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/BulletRifle.pref");
        //_bulletList = new List<CBullet>();
    }

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
    /*
    public void setWeapon(int aState)
    {
        state = aState;
        switch(state)
        {
            case 1:
                _bulletAsset = Resources.Load <GameObject> ("Assets/Prefabs/Bullet/M1GarathBullet.pref");
                break;
            case 2:
                _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/GenericBullet.pref");
                break;
            case 3:
                _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/BulletRifle.pref");
                break;
            case 4:
                _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/BulletPistol.pref");
                break;
            case 5:
                _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/BulletShootGun.pref");
                break;
           
            case 6:
                _bulletAsset = Resources.Load<GameObject>("Assets/Prefabs/Bullet/RocketBullet.pref");
                break;
                

        }
        
    
    }
    */
    
    /*
    private CGenericBullet SelectTypeBullet(CGenericWeapon Weapond)
    {
        //Todo: en este caso se podria hacer lo siguiente
            //Se tiene que ver la manera de crear ballas para cada arma sabiendo que arma se te da
             // En este caso Puedo Crear el Objecto
             //le paso el arma, me comprueba cual es y luego me Crea la bala me la agrega y me agrega la logica de movimiento especifica

        switch (Weapond.getNum())
        {
            case 1:


                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:

                break;

        }
        
    }
    */
public void Spawn(Vector2 pos, Vector2 vel,float Rot)
    {

        //Quaternion rotation = new Quaternion(transform.rotation.x * Rot,transform.rotation.y, Quaternion.identity.z, Quaternion.identity.w);

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
        //Revisar esta logica para usarla despues tendre que usarla en la parte superior
        //Recordar crear la bala asignale la fisica 
        // y luego agregarla esta parte podria quedar en desuso 
        //o podria separarlo de la siguiente manera
        //averiguar si la logica de las armas puede ser ejecutada una vez a la hora de ser disparada pero lo dudo
        //Tratar de Proligear esta parte del codigo 
        //TODO: Averiguar que hacer con el bean sniper como solucionar eso
        #region Tengo que investigar como usar esto para rotarlo en 7 direcciones
        GameObject obj = (GameObject)Instantiate(_bulletAsset, pos, Quaternion.identity);
        Vector3 localScale=obj.transform.localScale;
        localScale.x *= Rot;
        obj.transform.localScale = localScale;
        CGenericBullet newBullet = obj.GetComponent<CBullet>();
        newBullet.AddVel(vel);
        _bulletList.Add(newBullet);
        #endregion


    }
    public List<CGenericBullet> GetList()
    {
     
        return _bulletList;
    }
}


