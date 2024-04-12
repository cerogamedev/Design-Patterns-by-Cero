using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoSingleton<PotionManager>
{
    public BuffPotionController SelectedBuffPotion;
    public void Decorate(BuffPotionController clickedBuffPotion)
    {
        if (SelectedBuffPotion == clickedBuffPotion) { return; }

        if (SelectedBuffPotion.Potion is PotionDecorator decorator)
        {
            Debug.Log("Decorating Potions...");
            decorator.Decorate(clickedBuffPotion.Potion);
            clickedBuffPotion.Potion = decorator;

            //POLISH
        }
        else
        {
            Debug.Log("Cant decorate potions");
        }
    }
}
