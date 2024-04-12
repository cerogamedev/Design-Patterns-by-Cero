using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffPotionController : MonoBehaviour
{
    [SerializeField] private PotionTypeSO potionType;

    private Button button;

    public IPoiton Potion { get; set; }

    private void Awake()
    {
        button = GetComponent<Button>();

        Potion = PotionFactory.CreatePotion(potionType);

        button.onClick.AddListener(() =>
      {
          OnButtonClick();
      });
    }
    public void OnButtonClick()
    {
        if(PotionManager.Instance.SelectedBuffPotion == null)
        {
            PotionManager.Instance.SelectedBuffPotion = this;
            Debug.Log("Potion Selected: " + Potion);
        }
        else
        {
            PotionManager.Instance.Decorate(this);
            PotionManager.Instance.SelectedBuffPotion = null;
        }
    }
}
