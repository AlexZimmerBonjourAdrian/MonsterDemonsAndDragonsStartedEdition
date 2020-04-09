using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CManagerWeapond : MonoBehaviour
{
    // Start is called before the first frame update
    private ArrayList _WeapondList = new ArrayList();
    [SerializeField] private GameObject _WeapondObject;
    
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void SpawnWeapond(Vector2 pos)
    {
        GameObject obj = (GameObject)Instantiate(_WeapondObject, pos, Quaternion.identity);
       
    }
}
