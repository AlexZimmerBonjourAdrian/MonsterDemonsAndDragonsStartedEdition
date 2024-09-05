using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CManagerWeapond : MonoBehaviour
{
    // Start is called before the first frame update
    public List<CGenericWeapon> _WeapondList = new List<CGenericWeapon>();
    [SerializeField] private GameObject _WeapondObject;
    [SerializeField] private Transform _transformWeapondManager;
    [SerializeField] private List<Transform> _transformList;
    public static CManagerWeapond Inst
    {
        get
        {
            if(_inst == null)
            {
                GameObject obj = new GameObject("WeapondManager");
                return obj.AddComponent<CManagerWeapond>();
            }
            return _inst;
        }
    }
    private static CManagerWeapond _inst;

    private void Awake()
    {
        if(_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
    }
  

    // Update is called once per frame
    void Update()
    {

        for(int i = _WeapondList.Count -1; i>=0;i--)
        {
            if(_WeapondList[i] == null)
            {
                _WeapondList.RemoveAt(i);
            }
        }
        #region Codigo provicional del manager
       if(Input.GetKeyDown(KeyCode.T))
        {
            SpawnWeapond(_transformWeapondManager.position);
        }

        #endregion
    }

    public void SpawnWeapond(Vector2 pos)
    {
        GameObject obj = (GameObject)Instantiate(_WeapondObject, pos, Quaternion.identity);
        CGenericWeapon newWeapon = obj.GetComponent<CMiniMiniGun>();
        _WeapondList.Add(newWeapon);
    }

   
}
