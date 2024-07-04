using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private void Awake()
    {
        SaveGame();
    }


    public void SaveGame()
    {
        SaveData ad = new SaveData(3);
        ad.SceneNumber.ComponentSet = new string[]{"asd","??????","0.12" };
        ad.level = 1;
        ad.name = "obbj1";
        Debug.Log(JsonUtility.ToJson(ad));

    }

}
