using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaker : MonoBehaviour
{
    void Start()
    {
        Scene NewScene = SceneManager.CreateScene("Test");
    }

    void Update()
    {
    }
}
