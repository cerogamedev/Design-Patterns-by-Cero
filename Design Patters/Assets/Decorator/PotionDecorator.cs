using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PotionDecorator : IPoiton
{
    protected IPoiton poiton;
    protected readonly int value;

    public PotionDecorator(int value)
    {
        this.value = value;
    }

    public void Decorate(IPoiton poiton)
    {
        if (ReferenceEquals(this, poiton))
        {
            Debug.LogWarning("Potion cant decorate itself");
            return;
        }
        if (this.poiton is PotionDecorator decorator)
        {
            decorator.Decorate(poiton);
        }
        else
            this.poiton = poiton;
    }

    public virtual int UsePotion()
    {
        return poiton?.UsePotion() + value ?? value;
    }
    
 
}
