using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DotDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler
{

    //  Fire event when dot is selected
    public static event Action<GameObject> onDotSelected = delegate { };
    public void DotSelectedTrigger()
    {
        onDotSelected(gameObject);
    }

    //  Fire event when input is complete
    public static event Action onSelectionComplete = delegate { };
    public void SelectionComplete()
    {
        onSelectionComplete();
    }

    //  Select dot on drag
    public void OnPointerDown(PointerEventData eventData)
    {
        DotSelectedTrigger();
    }

    // Complete selection on pointer up (touch end)
    public void OnPointerUp(PointerEventData eventData)
    {
        SelectionComplete();
    }

    private void OnMouseEnter()
    {
        if (Input.GetMouseButton(0))
        {
            DotSelectedTrigger();
        }
    }

    //  select dot on first input
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            DotSelectedTrigger();
        }
    }

    //  complete selection
    private void OnMouseUp()
    {
        SelectionComplete();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0))
        {
            DotSelectedTrigger();
        }
    }
}
