using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    private void Start()
    {
        EventManager.Instance.OnKeyPressed += EventManager_OnKeyPressed;

    }
    private void OnEnable()
    {
        EventManager.UnityActionEvent += UnityActionTesting;

    }
    private void OnDisable()
    {
        EventManager.UnityActionEvent -= UnityActionTesting;

    }
    public void EventManager_OnKeyPressed(object _object, System.EventArgs e)
    {
        Debug.Log("Heard by subscriber");
    }

    public void UnityActionTesting()
    {
        Debug.Log("Action is working");

        
    }
}
