using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCHaracterManager : MonoBehaviour
{
    // Start is called before the first frame update

        public static CCHaracterManager Inst
    {
        get
        {
            if(_inst== null)
            {
                GameObject obj = new GameObject("CharacterManager");
                return obj.AddComponent<CCHaracterManager>();
            }
            return _inst;
        }
    }
    private static CCHaracterManager _inst;
    private List<CGenericCharacter> _CharaterList;
    [SerializeField] private GameObject _CharacterAsset;
    private CGenericCharacter Script;
    public void Awake()
    {
        if(_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;

        _CharaterList = new List<CGenericCharacter>();
    }
    public void Update()
    {
       
        for(int i = _CharaterList.Count -1; i>=0;i--)
        {
            if(_CharaterList[i] == null)
            {
                _CharaterList.RemoveAt(i);
            }
        }
    }
    public void Spawn(Vector2 pos)
    {

        GameObject obj = (GameObject)Instantiate(_CharacterAsset, pos, Quaternion.identity);
       CGenericCharacter newEnemy = new 
            obj.GetComponent<CGenericCharacter>();
        _CharaterList.Add(newEnemy);

    }
    
    public void setAsset(GameObject AssetCharater)
    {
        _CharacterAsset = AssetCharater;
    }
    public GameObject GetAsset()
    {
        return _CharacterAsset;
    }


}

