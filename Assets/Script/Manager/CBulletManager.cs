using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBulletManager : CManager
{
    private static CBulletManager Inst = null;
    private List<CBullet> _bulletList;
    private GameObject _bulletAsset;


    //Temp system :: solo para usar en la etapa de prototypo
    private const int M1GaractBullet_STATE = 1;
    private const int GenericBullet_STATE = 2;
    private const int ShootGunBullet_STATE = 3;

    public CBulletManager()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Awake()
    {
        Inst = this;
        //_bulletAsset = Resources.Load<GameObject>("Bullet");
        _bulletList = new List<CBullet>();
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
    public void Update()
    {
        for(int i = _bulletList.Count -1; i >= 0; i--)
        {
            if (_bulletList[i] == null)
                _bulletList.RemoveAt(i);
        }
    }
    public void Spawn(Vector2 pos, Vector2 vel)
    {
        GameObject obj = (GameObject)Instantiate(_bulletAsset, pos, Quaternion.identity);
        //CBullet newBullet = obj.GetComponent<CBullet>();
        // newBullet.AddVel(vel);
        // Destroy(obj, 3f);
        //_bulletList.Add(newBullet);
        CBullet newbullet = obj.GetComponent<CM1GaratBullet>();
        _bulletList.Add(newbullet);
    }
}


