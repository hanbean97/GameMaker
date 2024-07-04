using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierarchySc : MonoBehaviour// 중심우선탐색
{
   


    private void Awake()
    {
    }
}

public class hierarchyTree<T>
{
    public T Node { get; set; }
    List<hierarchyTree<T>> childNode { get; set; } = new List<hierarchyTree<T>>();
}

