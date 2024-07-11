using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HierarchyBTobj : MonoBehaviour
{
    Button ChildOpenBt;
    bool openclose;
    private void Awake()
    {
        ChildOpenBt = GetComponent<Button>();
        ChildOpenBt.onClick.AddListener(clickBt);
    }

    public void checkchild()
    {
        
    }

    private void clickBt()
    {
        switch (openclose)
        {
            case true:
                openchild();
                break;
            case false:
                closechild();
                break;
        }
        openclose= !openclose;
    }

    private void openchild()
    {
        if(transform.childCount > 0)
        {
            for(int i =0; i < transform.childCount; i++)
            { 
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }

    private void closechild()
    {
         

    }
}
