using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void Start()
    {
        SaveGame();
    }


    public void SaveGame()
    {
        SaveData ad = new SaveData(3);
        ad.SceneNumber[0].ComponentSet = new string[]{"asd","������","0.12" };
        ad.level = 1;
        Debug.Log(JsonUtility.ToJson(ad));

    }

}
