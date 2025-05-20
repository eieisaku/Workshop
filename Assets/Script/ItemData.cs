using UnityEngine;

[CreateAssetMenu(fileName ="NewItemData",menuName ="WorkShop/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite itemIcon;
    internal Sprite itemicon;
}
