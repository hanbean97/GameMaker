using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    GameObject MyObj;
    Transform canvas;
    RectTransform rect;
    public RectTransform Rec { get { return rect; } set { rect = value; } }
    Image img;
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
        img = GetComponent<Image>();
        MyObj = new GameObject(); 
        MyObj.AddComponent<SpriteRenderer>().sprite = img.sprite;
    }
  
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(canvas);
        transform.SetAsLastSibling();//맨밑으로 옮겨 가장 위에 그려지게 
        img.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)//드래그중
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.parent == canvas)//어디에 속하지 않을때
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D ray = Physics2D.Raycast(mousePos, Vector3.forward, float.PositiveInfinity, ~LayerMask.GetMask("UI"));
            if (ray && ray.transform.CompareTag(""))
            {
                Instantiate(MyObj);
            }

        }
        img.raycastTarget = true;
    }

}
