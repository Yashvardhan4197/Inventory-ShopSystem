using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{

    private GameObject itemobject;
    [SerializeField] public int itemId;
    [SerializeField] public GameObject Name;
    [SerializeField] public GameObject AmountText;
    [SerializeField] public Button UseButton;


    private void Awake()
    {
        
        //UseButton.onClick.AddListener(ShopController.Instance.UseInventoryObject(GetComponentInParent<InventoryObject>().)
    }
    public GameObject GetName()
    {
        return Name;
    }
    public GameObject GetAmounttext()
    {
        return AmountText;
    }
}
