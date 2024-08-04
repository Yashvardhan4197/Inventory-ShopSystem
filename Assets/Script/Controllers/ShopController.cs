using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject ShopInventory;
    private static ShopController instance;
    public static ShopController Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


   public void UseInventoryObject(ItemObject item)
    {
        inventory.RemoveItem(item,1);
    }


}
