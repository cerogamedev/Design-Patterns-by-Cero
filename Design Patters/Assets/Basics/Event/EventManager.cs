using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }

    public event EventHandler OnKeyPressed;

    public static Action UnityActionEvent;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        OnKeyPressed += TestingKeyPressed;

    }
    public void TestingKeyPressed(object sender, EventArgs e)
    {
        Debug.Log("Its okey");
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnKeyPressed?.Invoke(this, EventArgs.Empty);

            UnityActionEvent?.Invoke();
        }
    }
}
