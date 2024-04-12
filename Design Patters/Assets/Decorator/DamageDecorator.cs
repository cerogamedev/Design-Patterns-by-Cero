using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDecorator : PotionDecorator
{
    public DamageDecorator(int value) : base(value) { }

    public override int UsePotion()
    {
        DamageOthers();
        return poiton?.UsePotion() ?? 0;
    }
    public void DamageOthers()
    {
        Debug.Log("damage");

    }
}
