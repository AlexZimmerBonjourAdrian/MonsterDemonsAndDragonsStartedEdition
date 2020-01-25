using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyManager : MonoBehaviour
{

    public static CEnemyManager Inst
    {
        get
        {
            if(_inst == null)
            {
                GameObject obj = new GameObject("EnemyManager");
                return obj.AddComponent<CEnemyManager>();
            }
            return _inst;
        }
    }
    private static CEnemyManager _inst;

    private List<CEnemy> _EnemyList;
    [SerializeField] private GameObject _EnemyAsset;

    // Start is called before the first frame update

    public void Awake()
    {
        
        if(_inst != null && _inst !=this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;

        _EnemyList = new List<CEnemy>();
    }
    public void Update()
    {
        

        for(int i = _EnemyList.Count -1; i >=0;i--)
        {
            if (_EnemyList[i] == null)
                _EnemyList.RemoveAt(i);
        }

    }
    
    public void Spawn(Vector2 pos)
    {
        GameObject obj = (GameObject)Instantiate(_EnemyAsset, pos, Quaternion.identity);
        CEnemy newEnemy = obj.GetComponent<CEnemy>();
        _EnemyList.Add(newEnemy);
    }

}
