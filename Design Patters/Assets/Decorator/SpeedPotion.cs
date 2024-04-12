using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : IPoiton
{
    private readonly int value;
    public SpeedPotion (int value)
    {
        this.value = value;
    }
    public int UsePotion()
    {
        return value;
    }

}
