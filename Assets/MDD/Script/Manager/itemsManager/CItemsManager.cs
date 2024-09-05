using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItemsManager : MonoBehaviour
{
    // Start is called before the first frame update

    private ArrayList _itemList = new ArrayList();
        [SerializeField] private GameObject _ItemObject;
    //Referencia esto se va a hacer para cuando se dese setear todos los objetos seteables
     [SerializeField]private  GameObject[] _AssetManager;
    [SerializeField] private Transform[] _LocationToSpawn;
    [SerializeField] private Transform _transformWeapondManager;
        
    public static CItemsManager Inst
    {
        get
        {
            if(_inst == null)
            {
                GameObject obj = new GameObject("ItemsManager");
                return obj.AddComponent<CItemsManager>();
            }
            return _inst;
        }
    }
    private static CItemsManager _inst;
    private void Awake()
    {
        if(_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
        _AssetManager = new GameObject[8];
       
        //_AssetManager[0] = obj;

    }

    private void Start()
    {
       
        _AssetManager[0] = Resources.Load("/Assets/Prefabs/Bullet/M1GarathBullet.prefab") as GameObject;

    }
    // Update is called once per frame
    void Update()
    {
        /*
        for(int i=0; i<= _AssetManager.Length - 1; i++)
        {
            Debug.Log(_AssetManager[i].name);
        }
        */
        for(int i = _itemList.Count -1;i>=0;i--)
        {
            if(_itemList[i]==null)
            {
                _itemList.RemoveAt(i);
            }
        }
    }

    public void SpawItem(Vector2 pos)
    {
        GameObject obs = (GameObject)Instantiate(_AssetManager[0], pos, Quaternion.identity);
        CGenericItem newItems = obs.GetComponent<CPotion>();
        _itemList.Add(newItems);
    }
    
}
