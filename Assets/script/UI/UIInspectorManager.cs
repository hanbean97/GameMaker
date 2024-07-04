using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInspectorManager : MonoBehaviour
{

    [SerializeField] int max, min;
    [SerializeField, Range(0, 1)] float ratio;


    private void Awake()
    {
       
    }

}
