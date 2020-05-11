using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;


[Serializable]
public class CPlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    [SerializeField]
    private Transform _SpawnPoint;
    [SerializeField]
    private int _PlayerNumber;
    [SerializeField]
    private GameObject _Instance;
    [SerializeField]
    private CharacterController2D _movement;
    [SerializeField]
    private CShootScript _shoot;
    */
    [SerializeField]
    private List<PlayerMovement> _PlayerList = new List<PlayerMovement>();
    [SerializeField]
    private List<GameObject> _ListObject = new List<GameObject>();
    [SerializeField]
    private GameObject[] _AssetManager=new GameObject[2];
    private GameObject _obj;
    private Transform _serchTransform;

    public static CPlayerManager Inst
    {
        get
        {
            if (_inst == null)
            {
                GameObject obj = new GameObject("CPlayerManager");
                return obj.AddComponent<CPlayerManager>();
            }
            return _inst;
        }
    }
    private static CPlayerManager _inst;

    private void Awake()
    {
        if (_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;

    }
    public void Start()
    {
        /*
        _AssetManager[0] = Resources.Load<GameObject>("Asset/Prefabs/Character/PlayerLoop");
        _AssetManager[1] = Resources.Load<GameObject>("Asset/Prefabs/Character/PlayerNatalia");
        */
    }
    void Update()
    {
        for (int i = _PlayerList.Count - 1; i >= 0; i--)
        {
            if (_PlayerList[i] == null)
            {
                _PlayerList.RemoveAt(i);

            }
        }
        for (int i = _ListObject.Count - 1; i >= 0; i--)
        {
            if (_ListObject[i] == null)
            {
                _ListObject.RemoveAt(i);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
        //private GameObject _CanvasGameObject;

        /*
        public void Reset()
        {

        }
        */

    }
    public void Spawn(Vector2 Pos)
    {
        if (_PlayerList.Count <= 2)
        {
            GameObject obj = (GameObject)Instantiate(_AssetManager[0], Pos, Quaternion.identity);
            PlayerMovement newPlayer = obj.GetComponent<CPlayerLoop>();
            _PlayerList.Add(newPlayer);
            _obj = obj;
        }
    }
    public void changedCharacter(int count, int NumPlayer)
    {

        PlayerMovement newPlayer;
        _ListObject.Add(_obj);

        //for (int i = _PlayerList.Count - 1; i <= 0; i--)
        //{

        switch (count)
        {
            case 1:
                Destroy(_obj);
                _obj = (GameObject)Instantiate(_AssetManager[0], _ListObject[0].transform.position, Quaternion.identity);
                newPlayer = _obj.GetComponent<CPlayerLoop>();
                _PlayerList[NumPlayer] = newPlayer;
                _ListObject[0] = null;

                /*
                 _obj=(GameObject)Instantiate(_AssetManager[0],position)
                _PlayerList[i]=
                */
                break;
            case 2:
                Destroy(_obj);
                _obj = (GameObject)Instantiate(_AssetManager[1], _ListObject[0].transform.position, Quaternion.identity);
                newPlayer = _obj.GetComponent<CPlayerNatalia>();
                _PlayerList[NumPlayer] = newPlayer;
                _ListObject[0] = null;
                break;

            default:
                Debug.LogError("No existe el Modelo");
                break;
                //}
        }

    }
}
