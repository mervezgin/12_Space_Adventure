using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour , IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool pressTheButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressTheButton = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressTheButton = false;
    }
}
