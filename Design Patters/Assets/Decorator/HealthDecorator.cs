using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecorator : PotionDecorator
{
    public HealthDecorator(int value) : base(value) { }

    public override int UsePotion()
    {
        HealOthers();
        return poiton?.UsePotion() ?? 0;
    }
    public void HealOthers()
    {
        Debug.Log("health");
    }
}
