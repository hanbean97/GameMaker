using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class inspectorDrag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{

    RectTransform rect;


    private void Awake()
    {
        rect = GetComponent<RectTransform>();

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {

    }


}
