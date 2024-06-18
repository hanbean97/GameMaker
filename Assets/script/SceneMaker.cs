using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaker : MonoBehaviour
{
    [SerializeField] Scene testsc;
    [SerializeField] Vector2 testsc2;

    void Start()
    {
        Scene NewScene = SceneManager.CreateScene("Test");
        //Scene testScene = SceneManager.activeSceneChanged<,>

        // Resources.UnloadUnusedAssets();
        // GC.Collect();
        
    }

    void Update()
    {
    }
}
