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
    ArrayList lista = new ArrayList();
    private static CCHaracterManager _inst;
    private  ArrayList _CharaterList = new ArrayList();
    [SerializeField] private GameObject _CharacterAsset;
    //private CCharacterControllers Script;
    public void Awake()
    {
        if(_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;

        //_CharacterAsset = Resources.Load("MuffetSprite") as GameObject;
        //_CharaterList = new List<CharacterController>();
    }
    public void Update()
    {
        /*
         for(int i = _CharaterList.Count -1; i>=0;i--)
         {
             if(_CharaterList[i] == null)
             {
                 _CharaterList.RemoveAt(i);
             }
         }

         */
        for (int i=_CharaterList.Count - 1; i >= 0; i--)
        {
            if (_CharaterList[i] == null)
                _CharaterList.RemoveAt(i);
        }
    }
    public void Spawn(Vector2 pos)
    {

        GameObject obj = (GameObject)Instantiate(_CharacterAsset, pos, Quaternion.identity);
        //CCharacterControllers character = new CCharacterMuffet();
        CCharacterControllers newcharacter = obj.GetComponent<CCharacterMuffet>();
        //character = obj.GetComponent<CCharacterMuffet>();
       // Debug.Log(character.name);
        _CharaterList.Add((newcharacter));
        
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

