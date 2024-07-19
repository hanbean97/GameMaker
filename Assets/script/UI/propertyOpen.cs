using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propertyOpen : MonoBehaviour
{
    [SerializeField] Transform OpenSlot;
    List<GameObject> propertys = new List<GameObject>();
    [SerializeField] Button OpenBt;
    bool IsOpen= true;
    private void Awake()
    {
        OpenBt.onClick.AddListener(ViewProperty);
    }
    private void ViewProperty()
    {
        IsOpen = !IsOpen;
        for (int i = 0; i < propertys.Count; i++)
        {
            propertys[i].SetActive(IsOpen);
        }

        switch (IsOpen)
        {
            case true:
                
                break;  
            case false:
                break;
        }


    }
}
