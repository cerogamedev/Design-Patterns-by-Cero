using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="NewSpell", menuName ="Assets/Strategy")]
public class MagicSpell : AbilityStrategy
{
    [SerializeField] private GameObject magicPrefab;
    [SerializeField] private float selfDesturactionTime;
    public override void UseAbility()
    {
        
    }
}
