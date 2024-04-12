using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IShape
{
    public void Initialize()
    {

    }

    public void SayYourName()
    {
        Debug.Log(this.name);
    }
}
