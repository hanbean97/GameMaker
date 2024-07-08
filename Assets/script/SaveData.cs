using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaveData
{
    UserScene[] userScenes;

     SaveData(int activescene )
    {
        userScenes = new UserScene[activescene];
        userScenes[0].Objs[0] = new UserObj();
        
    }
}

public class UserScene// ���� json �߰��� ��ü�� Ŭ���� �߰��� ����
{
    public UserObj[] Objs;
    public UserUI[] Uis;
}

public class UserObj
{
    public string name;
    public string ImageRoute;
    public float x, y, z;
    public string[] propertyRoute;
    public UserObj[] Child;

}

public class UserUI
{
    public string name;
    public string ImageRoute;
    public float Rectx, Recty, Rectz;
    public string[] propertyRoute;
    public UserUI[] Child;

}