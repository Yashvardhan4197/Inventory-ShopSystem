using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newEquipmentItem",menuName ="ScriptableObjects/Item/EquipmentItem")]
public class EquipmentItem : ItemObject
{
    [SerializeField] public int attackValue;
    [SerializeField] public int dafenceValue;

    public EquipmentItem() 
    {
        type=ItemType.Equipment;
    }
}
