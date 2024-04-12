using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPotionController : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            OnMainButtonClick();
        });
    }
    public void OnMainButtonClick()
    {
        if (PotionManager.Instance.SelectedBuffPotion != null)
        {
            PotionManager.Instance.SelectedBuffPotion.Potion.UsePotion();
        }
        else
        {
            Debug.Log("Speed potion use w/out any other potions");
        }
    }
}
