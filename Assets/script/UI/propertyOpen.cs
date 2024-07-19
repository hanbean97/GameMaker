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
    RectTransform propertyRect;
    float closeHeight;
    private void Awake()
    {
        propertyRect = GetComponent<RectTransform>();
        closeHeight = OpenBt.GetComponent<RectTransform>().sizeDelta.y;
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
            case true://글자하나에 40의 크기로 설정
                int openLenght =40*(propertys.Count+1);
                propertyRect.sizeDelta = new Vector2(propertyRect.sizeDelta.x, openLenght);
                break;  
            case false:
                propertyRect.sizeDelta = new Vector2(propertyRect.sizeDelta.x,closeHeight);
                break;
        }


    }
}
