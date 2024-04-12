using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Potions",menuName ="Assets/Decorator/ExampleUsage")]
public class PotionTypeSO : ScriptableObject
{
    public int value;
    public PotionType type;
}
public enum PotionType
{
    Speed,
    Health,
    Damage
}
