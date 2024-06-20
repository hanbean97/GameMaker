using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class SaveData
{
    public int level;
    public SceneInData[] SceneNumber;
    public class SceneInData
    {
        public string[] ComponentSet;
        public SceneInData()
        {

        }

    }
    public SaveData(int sceneNum)
    {
        SceneNumber = new SceneInData[sceneNum];
        for (int i = 0; i < sceneNum; i++)
        {
            SceneNumber[i] = new SceneInData();
        }   
    }
}

