using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SceneMaker : MonoBehaviour
{
    [SerializeField] Scene testsc;
    [SerializeField] Vector2 testsc2;
    bool[] SceneIndex;
    [SerializeField] int maxScene;
    private void Awake()
    {
        SceneIndex = new bool[maxScene];
        
    }

    void Start()
    {
        Scene NewScene = SceneManager.CreateScene("Test");
        SceneManager.LoadSceneAsync(1,LoadSceneMode.Additive);
        //Scene testScene = SceneManager.activeSceneChanged<,>
        GameObject tesObj = new GameObject();
        DontDestroyOnLoad(tesObj);
        // Resources.UnloadUnusedAssets();
        // GC.Collect();
        SceneManager.MoveGameObjectToScene(tesObj, NewScene);

      Debug.Log(Application.persistentDataPath);
        Debug.Log(Application.streamingAssetsPath);
    }

    void Update()
    {
    }
}
