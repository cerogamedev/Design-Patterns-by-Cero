using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericManager : MonoBehaviour
{
    void Start()
    {
        Debug.Log(GetTheType("string"));
    }

    public T GetTheType<T>(T type)
    {
        return type;
    }
}
