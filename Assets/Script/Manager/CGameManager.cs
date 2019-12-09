using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CGameManager : MonoBehaviour
{
    public static CGameManager Inst
    {
        get
        {
            if (_inst == null)
            {
                GameObject obj = new GameObject("CGameManager");
                return obj.AddComponent<CGameManager>();
            }
            return _inst;
        }
    }
    private static CGameManager _inst;
    private AsyncOperation _currentLoadScene;

    public void Awake()
    {
        if (_inst != null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
    }

    public void Update()
    {

        //Debug.Log(IsLoadingScene());


    }
    public void LateUpdate()
    {
        if(_currentLoadScene != null)
        {
            if (_currentLoadScene.isDone)
                _currentLoadScene = null;
        }
    }
    public bool IsLoadingScene()
    {
        return _currentLoadScene != null && !_currentLoadScene.isDone;
    // Start is called before the first frame updat
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadSceneAsync(string name)
    {
        _currentLoadScene = SceneManager.LoadSceneAsync(name);
    }
    public void LoadSceneAsyncAdditive(string name)
    {
        _currentLoadScene = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
    }
}
