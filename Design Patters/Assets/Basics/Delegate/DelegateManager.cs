using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    public delegate void EmptyDelegate();

    private EmptyDelegate emptyDelegateFunction;


    //sona döndürülmek istenen deðer girilerek delegate yazma
    private Func<float, bool> floatInAction;

    private void Start()
    {
        emptyDelegateFunction = () =>
        {
            Debug.Log("Lambda expression!!!!");
            Debug.Log("Its great well working");
        };

        emptyDelegateFunction();


        floatInAction = (float f) =>
        {
            return f < 5.6;
        };

        Debug.Log(floatInAction(7.6f));

    }
}
