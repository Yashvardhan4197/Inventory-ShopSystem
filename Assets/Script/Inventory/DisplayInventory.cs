using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;
    public GridLayoutGroup gridLayoutGroup;

    private void Start()
    {
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {

        foreach(KeyValuePair<ItemObject,int> item in inventory.Containers) 
        {
            var obj = Instantiate(item.Key.itemPrefab, gridLayoutGroup.gameObject.transform);
            obj.GetComponent<ItemSlot>().GetName().GetComponent<TextMeshProUGUI>().text = item.Key.Description;
            obj.GetComponent<ItemSlot>().GetAmounttext().GetComponent<TextMeshProUGUI>().text = item.Value.ToString("n0");
        }
        /*
        for(int i = 0; i < inventory.Containers.Count; i++)
        {
            var obj = Instantiate(inventory.Containers[i].item.itemPrefab,this.transform);
            obj.GetComponent<ItemPrefab>().GetName().GetComponent<TextMeshProUGUI>().text=inventory.Containers[i].item.Description;
            obj.GetComponent<ItemPrefab>().GetAmounttext().GetComponent<TextMeshProUGUI>().text = inventory.Containers[i].amount.ToString("n0");
        }
        */
    }
}
