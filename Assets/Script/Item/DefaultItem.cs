using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="newDefaultItem",menuName ="ScriptableObjects/Item/DefaultItem")]
public class DefaultItem : ItemObject
{
    public DefaultItem()
    {
        type=ItemType.Default;
    }
}
