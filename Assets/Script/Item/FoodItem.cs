using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newFoodItem",menuName ="ScriptableObjects/Item/FoodItem")]
public class FoodItem : ItemObject
{
    [SerializeField] public int healthIncreased;

    public FoodItem()
    {
        type=ItemType.FoodItem;
    }
}
