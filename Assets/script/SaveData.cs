using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SaveData
{
    UserScene[] userScenes;

    void Setting()
    {


    }
}

public class UserScene// 저장 json 추가할 객체는 클래스 추가로 넣음
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