using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Action OnClickAction;
    public void OnPointerDown(PointerEventData data)
    {
        //Debug.Log("OnPonterDown");
    }

    public void OnPointerUp(PointerEventData data)
    {
        //Debug.Log("OnPonterUp");
    }

    public void OnPointerClick(PointerEventData data)
    {
        OnClickAction?.Invoke();
        Debug.Log("OnPointerClick");
    }
}
