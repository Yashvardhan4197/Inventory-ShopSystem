using AYellowpaper.SerializedCollections;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newInventory",menuName ="ScriptableObjects/Inventory/InventoryObject")]
public class InventoryObject : ScriptableObject
{

    [SerializedDictionary("itemType", "Amount")]
    public SerializedDictionary<ItemObject,int>Containers=new SerializedDictionary<ItemObject,int>();
    public void AddItem(ItemObject item,int val)
    {
       

        if(Containers.TryGetValue(item, out int currentVal))
        {
            Containers[item] += val;
        }
        else
        {
            Containers.Add(item,val);
        }
    }

    public void RemoveItem(ItemObject item,int val)
    {
        if (Containers.TryGetValue(item, out int currentVal))
        {
            Containers[item]-=val;
        }
    }
}

