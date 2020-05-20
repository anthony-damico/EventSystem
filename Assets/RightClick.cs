using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class RightClick : MonoBehaviour, IPointerClickHandler
{

    public UnityEvent leftClick;
    public UnityEvent middleClick;
    public UnityEvent rightClick;
    public UnityEvent submit;
    public UnityEvent cancel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            leftClick.Invoke();
        else if (eventData.button == PointerEventData.InputButton.Middle)
            middleClick.Invoke();
        else if (eventData.button == PointerEventData.InputButton.Right)
            rightClick.Invoke();
    }

    public void Update()
    {
        if(Input.GetButton("Submit"))
        {
            submit.Invoke();
        }
        else if (Input.GetButton("Cancel"))
        {
            cancel.Invoke();
        }
    }
}
