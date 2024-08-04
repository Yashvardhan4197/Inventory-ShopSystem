using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum ItemType
{
    Default,FoodItem,Equipment
}
public abstract class ItemObject : ScriptableObject
{
    [SerializeField] public GameObject itemPrefab;
    [SerializeField] public string Description;
    [SerializeField] public ItemType type;

}
