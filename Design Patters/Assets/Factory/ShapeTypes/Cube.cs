using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IShape
{
    public void Initialize()
    {
        
    }

    public void SayYourName()
    {
        Debug.Log(this.name);
    }

}
