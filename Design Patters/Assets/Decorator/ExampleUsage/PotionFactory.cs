using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PotionFactory
{
    public static IPoiton CreatePotion(PotionTypeSO potionType)
    {
        return potionType.type switch
        {
            PotionType.Health => new HealthDecorator(potionType.value),
            PotionType.Damage => new DamageDecorator(potionType.value),
            _ => new SpeedPotion(potionType.value)
        };
    }
}
